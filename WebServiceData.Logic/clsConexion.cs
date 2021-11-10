using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServiceData.Logic
{
    class clsConexion
    {
        public string getConexion()
        {
            return ConfigurationManager.ConnectionStrings["ConexionDB"].ToString();
        }
    }
}
