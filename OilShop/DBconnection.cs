using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OilShop
{
    class DBconnection
    {
        public string MyConnection()
        {
            string con = @"Data Source=.\SQLEXPRESS;Initial Catalog=FJT;Integrated Security=True";
          //  string con = @"Data Source=DESKTOP-NFB7HPQ\SQLEXPRESS;Initial Catalog=FJT;Integrated Security=True";
            return con;
        }
    }
}
