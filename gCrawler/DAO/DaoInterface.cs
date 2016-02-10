using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gCrawler.DAO
{
    interface DaoInterface
    {
        void create();

        void  read();

        void  update();

        void  delete();
    }
}