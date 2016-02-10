using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace gCrawler.DAO
{
    public class DaoImplement : DaoInterface
    {
        public object MessageBox { get; private set; }

        public void create()
        {
            throw new NotImplementedException();
        }

        public void delete()
        {
            throw new NotImplementedException();
        }

        public void read()
        {
            throw new NotImplementedException();
        }

        public void update()
        {
            throw new NotImplementedException();
        }

        private bool connectToDataBase()
        {
            string connetionString = null;
            SqlConnection connection;
         
            bool connectOK = true;
            connetionString = "Data Source=ServerName;Initial Catalog=DatabaseName;User ID=UserName;Password=Password";
            connection = new SqlConnection(connetionString);
            try {
                connection.Open();
            } catch (Exception ex) {
                connectOK =  false;
            }
            return connectOK;
        }
    }
}