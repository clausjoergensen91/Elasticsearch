using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elasticsearch.Net;

namespace ElasticsearchApp
{
    public class Elasticsearch
    {
        public Elasticsearch()
        {
            var node = new Uri("http://localhost:9200");
            var connectionPool = new SniffingConnectionPool(new[] { node });
            var config = new ConnectionConfiguration(node);
            var client = new ElasticLowLevelClient(config);
        }
    }
}
