using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElasticDao;

namespace Controller
{
    public class IndexCtr
    {
        DaoIndex daoIndex;

        public IndexCtr()
        {
            daoIndex = new DaoIndex();
        }

        public int CreateIndex(string name)
        {
            return daoIndex.CreateIndex(name);
        }

        public int DeleteIndex(string name)
        {
            return daoIndex.DeleteIndex(name);
        }
    }
}
