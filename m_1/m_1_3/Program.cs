using System;
using System.Collections.Generic;

namespace m_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prime Numbers between 1 and 100:");
           // int[] Arr;
            List<int> Arr = new List<int>();
            //Arr = new int[100];
            for(int i=0;i<100;i++)//初始化数组，赋值1到100
            {
                //Arr[i] = i + 1;
                Arr.Add(i + 1);
            }

            for(int i=2;i<100;i++)//从倍数2开始比较
            {
                Erato(Arr, i);
                
            }
            foreach(int element in Arr)
            {
                Console.WriteLine(element + " ");
            }


        }

        public static void Erato(List<int>  array,int a)//a倍数
        {
            double judging;
            int remainder;
            //foreach(int element in array)
           for(int element=100;element>0;element--)
            {
                remainder = element % a;
                judging = element / a;
                if(judging>1&&judging!=1&&remainder==0)//如果商>0 & 商！=1 & 余数=0
                {
                    array.Remove(element);
                }
            }
        }


    }
}
