namespace test
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    public class Model1 : DbContext
    {
        //您的上下文已配置为从您的应用程序的配置文件(App.config 或 Web.config)
        //使用“Model1”连接字符串。默认情况下，此连接字符串针对您的 LocalDb 实例上的
        //“test.Model1”数据库。
        // 
        //如果您想要针对其他数据库和/或数据库提供程序，请在应用程序配置文件中修改“Model1”
        //连接字符串。
        public Model1()
            : base("name=Model1")
        {
        }

        //为您要在模型中包含的每种实体类型都添加 DbSet。有关配置和使用 Code First  模型
        //的详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=390109。

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        public class Blog
        {
            public int BlogId { get; set; }
            public string Url { get; set; }
            public int Rating { get; set; }
            public List<Post> Posts { get; set; }
        }

        public class Post
        {
            public int PostId { get; set; }
            public string Title { get; set; }
            public string Content { get; set; }
            public string Comment { get; set; }

            public int BlogId { get; set; }
            public Blog Blog { get; set; }
        }

        public class BloggingContext : DbContext
        {
            public BloggingContext() : base("BlogDataBase")
            {
                Database.SetInitializer(new DropCreateDatabaseIfModelChanges<BloggingContext>());
            }

            public DbSet<Blog> Blogs { get; set; }
            public DbSet<Post> Posts { get; set; }
        }

        public void AddBlog()
        {
            using (var db = new BloggingContext())
            {
                var blog = new Blog { Url = "http://sample.com", Rating = 3 };
                blog.Posts = new List<Post>()
            {
                new Post(){Title="Test1",Content = "Hello"},
                new Post(){Title="Test2",Content="Hello"}
            };
                db.Blogs.Add(blog);
                db.SaveChanges();
            }

        }

        public void AddPost()
        {
            using(var db = new BloggingContext())
            {
                var post = new Post { Title = "Test3", Content = "Hello", BlogId = 1 };
                db.Entry(post).State = EntityState.Added;
                db.SaveChanges();
            }
        }

        public void DeletePost()
        {

        }


    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
    


}