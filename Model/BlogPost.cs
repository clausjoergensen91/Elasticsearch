using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nest;

namespace Model
{
    [ElasticsearchType(IdProperty = "Id", Name = "blog_post")]
    public class BlogPost
    {
        [String]
        public Guid? Id { get; set; }

        [String]
        public string Title { get; set; }

        [String]
        public string Body { get; set; }

        public override string ToString()
        {
            return string.Format("Id: '{0}', Title: '{1}', Body: '{2}'", Id, Title, Body);
        }
    }
}
