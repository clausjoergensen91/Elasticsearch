using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nest;
using Model;

namespace ElasticDao
{
    public class DaoIndex
    {

        public int CreateIndex(string name)
        {
            int rc = -1;

            var node = new Uri("http://localhost:9200");
            var connection = new ConnectionSettings(node);
            var client = new ElasticClient(connection);

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
            }

            return rc;
        }

        public int DeleteIndex(string name)
        {
            int rc = -1;

            var node = new Uri("http://localhost:9200");
            var connection = new ConnectionSettings(node);
            var client = new ElasticClient(connection);

            if (client.IndexExists(name).Exists)
            {
                var deleteIndex = client.DeleteIndex(name);
            }

            return rc;
        }

    }
}
