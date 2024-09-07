using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_Ejemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dinero = 0, opcion = 0, total = 0;
            string dato = "";
            Console.WriteLine("Cuanto dinero tienes?");
            dato = Console.ReadLine();
            dinero = Convert.ToInt32(dato);
            while(dinero >= 30 && opcion != 6)
            {
                Console.WriteLine("Que quieres comprar?\n\r1. Bebida $30\n\r2. Ensalada $45\n\r3. Sopa $30\n\r4. Comida $60\n\r5. Postre $30\n\r6. Salir");
                dato = Console.ReadLine();
                opcion = Convert.ToInt32(dato);
                switch(opcion)
                {
                    case 1:
                        dinero -= 30;
                        total += 30;
                        break;
                    case 2:
                        dinero -= 45;
                        total += 45;
                        break;
                    case 3:
                        dinero -= 30;
                        total += 30;
                        break;
                    case 4:
                        dinero -= 60;
                        total += 60;
                        break;
                    case 5:
                        dinero -= 30;
                        total += 30;
                        break;
                }
                Console.WriteLine("Tienes {0} y has gastado {1}", dinero, total);
            }
            Console.WriteLine("Adios");
            Console.ReadKey();      
        }
    }
}
