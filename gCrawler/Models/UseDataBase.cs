using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace gCrawler.Models
{
    public class UseDataBase
    {
        private string stringConnexion;
        private SqlConnection conn;
        public UseDataBase(string stringConnexion) {
            this.stringConnexion = stringConnexion;
            conn = null;
        }
        public DBPolyCrawlerEntities1 connectToDatabase() {
            DBPolyCrawlerEntities1 db = new DBPolyCrawlerEntities1();
            return db;
        }
        public void closeConnexion() {
            conn.Close();
        }

       
    }
}