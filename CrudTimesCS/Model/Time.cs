using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudTimesCS.Model
{
    public class Time
    {
        private static int codtimes;
        private static string nometimes;
        private static string logotimes;
        private static string frasetimes;

        private static string retorno;

        public static int Codtimes { get => codtimes; set => codtimes = value; }
        public static string Nometimes { get => nometimes; set => nometimes = value; }
        public static string Logotimes { get => logotimes; set => logotimes = value; }
        public static string Frasetimes { get => frasetimes; set => frasetimes = value; }

        public static string Retorno { get => retorno; set => retorno = value; }
    }
}
