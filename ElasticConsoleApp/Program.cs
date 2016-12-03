using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nest;

namespace ElasticConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var node = new Uri("http://localhost:9200");
            var settings = new ConnectionSettings(node);
            var client = new ElasticClient(settings);

            //Creates an index in Elasticsearch
            var createIndexResponse = client.CreateIndex("index-peter", c => c
                    .Settings(s => s
                        .NumberOfShards(5)
                        .NumberOfReplicas(1)
                    )
                    .Mappings(m => m
                        .Map<BlogPost>(d => d
                            .AutoMap()
                        )
                    )
                );

            if (!client.IndexExists("index-claus").Exists)
            {
                var createIndex = client.CreateIndex("index-claus");
            }

            //Creates a blogpost
            var blogPost = new BlogPost
            {
                Id = Guid.NewGuid(),
                Title = "First blog post",
                Body = "This is a very long blog post!"
            };

            var firstId = blogPost.Id;

            //Indexes the blogpost in the index
            var res = client.Index(blogPost, p => p
<<<<<<< HEAD
                .Index("index-claus")
                .Type("blogpost")
                .Id(1)
=======
                .Index("index-peter")
                .Id(blogPost.Id.ToString())
>>>>>>> fbfac17c95ce30d510f5ebc477d435af553433b6
                .Refresh());

            Console.WriteLine(res.CallDetails);

        }
    }
}
