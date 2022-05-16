using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudTimesCS.Model
{
    public class jogadores
    {
        private static int idjogadores;
        private static string nomejogadores;
        private static string emailjogadores;
        private static string fonejogadores;

        private static string retorno;

        public static int Idjogadores { get => idjogadores; set => idjogadores = value; }
        public static string Nomejogadores { get => nomejogadores; set => nomejogadores = value; }
        public static string Emailjogadores { get => emailjogadores; set => emailjogadores = value; }
        public static string Fonejogadores { get => fonejogadores; set => fonejogadores = value; }

        public static string Retorno { get => retorno; set => retorno = value; }
    }
}
