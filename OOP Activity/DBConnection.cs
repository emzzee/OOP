using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Activity
{
    class DBConnection
    {
        public string MyConnection()
        {
            string con = "Data Source=DESKTOP-53ML4D9\\SQLEXPRESS;Initial Catalog=OOP;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            return con;
        }
    }
}
