﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nest;
using Model;

namespace ElasticDao
{
    public class ElasticDao
    {
        private readonly Uri node;
        private readonly ConnectionSettings connectionSettings;
        private readonly ElasticClient client;
        private BlogPost blogPost;

        public ElasticDao()
        {
            node = new Uri("http://localhost:9200");
            connectionSettings = new ConnectionSettings(node);
            client = new ElasticClient(connectionSettings);
            client.ClusterHealth(ch => ch
                .Local());
        }

        public int CreateIndex(string name)
        {
            int rc = -1;

            if (!client.IndexExists(name).Exists)
            {
                var createIndex = client.CreateIndex(name, c => c
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
                rc = 0;
            }

            return rc;
        }

        public int DeleteIndex(string name)
        {
            int rc = -1;

            if (client.IndexExists(name).Exists)
            {
                var deleteIndex = client.DeleteIndex(name);
                rc = 0;
            }

            return rc;
        }

        public int PostBlogPost(string id, string title, string body)
        {
            int rc = -1;

            var resGet = client.Index(blogPost, p => p
                .Index("testindex")
                .Id(blogPost.Id.ToString())
                .Refresh());

            return rc;
        }

        public int CreateNode()
        {
            int rc = -1;



            return rc;
        }

    }
}
