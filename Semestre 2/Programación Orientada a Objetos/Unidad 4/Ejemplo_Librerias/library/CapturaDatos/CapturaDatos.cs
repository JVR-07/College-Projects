using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapturaDatos
{
    public class CapturaDato
    {
        //Métodos de la clase
        public static string String(string texto_pantalla)
        {
            Console.Write("\tIngrese {0} : ", texto_pantalla);
            return Console.ReadLine();
        }

        public static char Char(string texto_pantalla)
        {
            Console.Write("\tIngrese {0} : ", texto_pantalla);
            return char.Parse(Console.ReadLine());
        }

        public static int Int(string texto_pantalla)
        {
            Console.Write("\tIngrese {0} : ", texto_pantalla);
            return int.Parse(Console.ReadLine());
        }

        public static short Short(string texto_pantalla)
        {
            Console.Write("\tIngrese {0} : ", texto_pantalla);
            return short.Parse(Console.ReadLine());
        }

        public static long Long(string texto_pantalla)
        {
            Console.Write("\tIngrese {0} : ", texto_pantalla);
            return long.Parse(Console.ReadLine());
        }

        public static float Float(string texto_pantalla)
        {
            Console.Write("\tIngrese {0} : ", texto_pantalla);
            return float.Parse(Console.ReadLine());
        }

        public static double Double(string texto_pantalla)
        {
            Console.Write("\tIngrese {0} : ", texto_pantalla);
            return Convert.ToDouble(Console.ReadLine());
        }
        public CapturaDato()
        {

        }
    }
}