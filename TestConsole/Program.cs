//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Nest;
//using Model;

//namespace TestConsole
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Uri node = new Uri("http://localhost:9200");
//            ConnectionSettings connection = new ConnectionSettings(node);
//            ElasticClient client = new ElasticClient(connection);

//            var blogPost = new BlogPost
//            {
//                Id = Guid.NewGuid(),
//                Title = "First blog post",
//                Body = "This is very long blog post!"
//            };

//            var firstId = blogPost.Id;

//            var res = client.Index(blogPost, p => p
//               .Index("claus")
//               .Id(blogPost.Id.ToString())
//               .Refresh());
//        }
//    }
//}
