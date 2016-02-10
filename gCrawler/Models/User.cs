using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Reflection;
namespace gCrawler.Models
{
    public class User
    {
        private string name { get; set; }
        private string passWord { get; set; }
        private string ville { get; set; }
        public List<string> GetAllPropertyValues()
        {
            List<string> array = new List<string>();
           
            return array;
        }
    }
}