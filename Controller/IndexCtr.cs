using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElasticDao;
using Model;

namespace Controller
{
    public class IndexCtr
    {
        ElasticDao.ElasticDao elasticDao;

        public IndexCtr()
        {
            elasticDao = new ElasticDao.ElasticDao();
        }

        public int CreateIndex(string name)
        {
            return elasticDao.CreateIndex(name);
        }

        public int DeleteIndex(string name)
        {
            return elasticDao.DeleteIndex(name);
        }

        public int PostDocument(string name, Guid id, string title, string text)
        {
            return elasticDao.PostDocument(name, Guid.NewGuid(), title, text);
        }
    }
}
