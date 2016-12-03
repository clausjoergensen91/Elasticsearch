﻿using System;
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
            var settings = new ConnectionSettings(node)
                .DefaultIndex("index-json");
            var client = new ElasticClient(settings);

            ////Creates an index in Elasticsearch
            //var createIndexResponse = client.CreateIndex("index-claus", c => c
            //        .Settings(s => s
            //            .NumberOfShards(5)
            //            .NumberOfReplicas(1)
            //        )
            //        .Mappings(m => m
            //            .Map<BlogPost>(d => d
            //                .AutoMap()
            //            )
            //        )
            //    );

            ////Creates a blogpost
            //var blogPost = new BlogPost
            //{
            //    Id = Guid.NewGuid(),
            //    Title = "First blog post",
            //    Body = "This is a very long blog post!"
            //};

            //var blogPost2 = new BlogPost
            //{
            //    Id = Guid.NewGuid(),
            //    Title = "Second blog post",
            //    Body = "This is not a very long blog post!"
            //};


            ////Indexes the blogpost in the index
            //var res = client.Index(blogPost, p => p
            //    .Index("index-claus")
            //    .Id(blogPost.Id.ToString())
            //    .Refresh());

            ////Indexes the blogpost in the index
            //var res1 = client.Index(blogPost2, p => p
            //    .Index("index-claus")
            //    .Id(blogPost.Id.ToString())
            //    .Refresh());

            //var result = client.Search<BlogPost>(s => s
            //    .Type("BlogPost")
            //    .Query(p => p.Term(q => q.Body, "not")));

            //Console.WriteLine(result);

            var myJson = new
            {
                Title = "hello world",
                Description = "Say hello to the world!" 

            };

            if (!client.IndexExists("index-json").Exists)
            {
                client.CreateIndex("index-json");
            }

            var indexResponse = client.Index(myJson, i => i
                    .Index("index-json")
                    .Type("json")
                    .Id(1)
                    .Refresh()
                    );

        }
    }
}
