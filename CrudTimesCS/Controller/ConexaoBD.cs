using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudTimesCS.Controller
{
    class ConexaoBD
    {
        public static string conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\caio.esilva10\source\repos\CrudTimesCS\CrudTimesCS\bdtimescs.mdf;Integrated Security=True";
        }
    }
}
