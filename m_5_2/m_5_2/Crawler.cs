using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace m_5_2
{
    class Crawler
    {
        private Hashtable urls;
        private Queue<String> queue;
        private int count;
        private String originalSite;  //原始网址
        private bool run;
        public delegate void DownloadHandle(string args);
        public event DownloadHandle PageDownloaded;
        public event DownloadHandle PageDownloadFailed;

        public bool Run { get => run; set => run = value; }

        public Crawler(String startUrl)
        {
            urls = new Hashtable();
            urls.Add(startUrl, false);
            queue = new Queue<String>();
            queue.Enqueue(startUrl);
            count = 0;
            Run = true;

            //求原始网址
            int startIndex = startUrl.IndexOf(":") + 3, endIndex = startUrl.IndexOf("/", startIndex);
            originalSite = startUrl.Substring(startIndex, endIndex - startIndex);
        }

        public void Crawl()
        {
            while (Run)
            {
                string current;
                do
                {
                    current = null;
                    if (queue.Count == 0)
                    {
                        break;
                    }
                    current = queue.Dequeue();
                } while ((bool)urls[current]);  //防止爬取相同网页
                if (current == null)
                {
                    break;
                }
                string html = DownLoad(current); // 下载
                urls[current] = true;
                count++;
                Parse(current, html);  //解析,并加入新的链接
            }
        }

        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.ToString();
                File.WriteAllText(fileName + ".html", html, Encoding.UTF8);
                PageDownloaded(url);
                return html;
            }
            catch (Exception ex)
            {
                PageDownloadFailed(url + ":" + ex.Message);
                return "";
            }
        }

        private void Parse(string current, string html)
        {
            string strRef = @"(href|HREF)[ ]*=[ ]*[""'][^""'#>]+[""']";

            //求当前网页的网页前缀，用于将相对地址转换为绝对地址
            int endIndex = current.IndexOf("/", current.IndexOf(":") + 3);
            string prefix = current.Substring(0, endIndex);
            string protocol = current.Substring(0, current.IndexOf(":"));

            string htmlPattern = @"(.html|.htm)";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1).Trim('"', '\"', '#', '>');
                if (strRef.Length == 0) continue;
                //将相对地址转换为绝对地址
                if (!Regex.IsMatch(strRef, @"://"))
                {
                    if (Regex.IsMatch(strRef, @"^[a-zA-Z0-9]"))
                    {
                        strRef = new Regex(@"[^/]+$").Replace(current, strRef);
                    }
                    else if (strRef.StartsWith("//"))
                    {
                        strRef = protocol + ":" + strRef;
                    }
                    else if (strRef.StartsWith("/"))
                    {
                        strRef = prefix + strRef;
                    }
                    else if (strRef.StartsWith("./"))
                    {
                        strRef = new Regex(@"/[^/]/$").Replace(current, strRef.Substring(2, strRef.Length - 2));
                    }
                    else if (strRef.StartsWith("../"))
                    {
                        while (strRef.StartsWith("../"))
                        {
                            strRef = new Regex(@"[^/]+/[^/]+$").Replace(current, strRef);
                        }
                    }
                }
                if (!Regex.IsMatch(strRef, originalSite)) continue;  //只爬取原始网站上的信息
                if (!Regex.IsMatch(strRef, htmlPattern)) continue;  //只爬取html文本
                if (urls[strRef] == null)
                {
                    urls.Add(strRef, false);
                    queue.Enqueue(strRef);
                }
            }
        }
    }
}
