using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvAc.Class
{
    internal class ConnectionDB
    {
        public string GetConnection()
        {
            string con = "Data Source=DESKTOP-QJA7AKN;Initial Catalog=\"Vedenie Ucheta\";Integrated Security=True";
            return con;
        }
    }
}
