using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPV_sistema
{
    class SesioKudeatzailea
    {
        public static string ErabiltzaileIzena { get; set; }


        public static void Sartu(string izena)
        {
            ErabiltzaileIzena = izena;
        }

        public static void Irten()
        {
            ErabiltzaileIzena = null;
        }
    }
}
