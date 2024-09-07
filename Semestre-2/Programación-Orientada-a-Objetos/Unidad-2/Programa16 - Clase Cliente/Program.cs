using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa16___Clase_cliente
{
    internal class Program
    {
        //Declaración de la clase
        class Cliente
        {   // Campos de la clase
            private string nombre_cliente, direccion_cliente;
            private int numero_cliente;
            private long telefono_cliente;

            // Constructor de la clase
            public Cliente(string nombre_cliente, int numero_cliente, string direccion_cliente, long telefono_cliente)
            {
                this.nombre_cliente= nombre_cliente;
                this.numero_cliente= numero_cliente;
                this.direccion_cliente= direccion_cliente;
                this.telefono_cliente= telefono_cliente;
            }

            // Metodos de la clase
            //Método para calcular los ingresos de la venta
            public float CalcularVenta(int cantidad_vendida_producto, float precio_producto)
            {
                float ingresos_venta = 0;
                ingresos_venta = precio_producto * cantidad_vendida_producto;
                return ingresos_venta;
            }
            //Método para mostrar los datos de la venta
            public void DesplegarVenta(string nombre_producto, int cantidad_vendida_producto, float precio_producto, float ingresos_venta)
            {
                Console.WriteLine("\t\t*** Datos del cliente ***\n");
                Console.WriteLine("\tEl nombre del cliente es: {0}\n\tEl número del cliente es: {1}",this.nombre_cliente, this.numero_cliente);
                Console.WriteLine("\tLa dirección del cliente es: {0}\n\tEl teléfono del cliente es: {1}", this.direccion_cliente, this.numero_cliente);
                Console.WriteLine("\n\t\t*** Datos del producto ***\n");
                Console.WriteLine("\tEl nombre del producto es: {0}\n\tLa cantidad vendida del producto es: {1}\n\tEl precio del producto es: {2:C}",nombre_producto,cantidad_vendida_producto,precio_producto);
                Console.WriteLine("\n\t\t*** Datos de la venta***\n");
                Console.WriteLine("\tLos ingresos obtenidos de la venta son {0:C}\n",ingresos_venta);
            }

            //Destructor de la clase
            ~Cliente()
            {
                Console.WriteLine("\n\tLa memoria de la clase {0} ha sdio liberada", this.nombre_cliente);
            }
        }
        static void Main(string[] args)
        {
            //Declaración de variables
            string nombre_cliente, direccion_cliente, nombre_producto;
            int numero_cliente, cantidad_vendida_producto;
            long telefono_cliente;
            float precio_producto, ingresos_venta; 
            //Captura de datos del cliente
            Console.Write("\tIngrese el nombre del cliente: "); nombre_cliente = Console.ReadLine();
            Console.Write("\tIngrese el número del cliente: "); numero_cliente = int.Parse(Console.ReadLine());
            Console.Write("\tIngrese la dirección del cliente: "); direccion_cliente = Console.ReadLine();
            Console.Write("\tIngrese el teléfono del cliente: "); telefono_cliente = long.Parse(Console.ReadLine());
            Console.Write("\tPresione la tecla <ENTER o INTRO> para confirmar los valores");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();
            //Creacion del objeto con constructor
            Cliente Javier = new Cliente(nombre_cliente, numero_cliente, direccion_cliente, telefono_cliente);
            //Captura de datos de la venta
            Console.Write("\tIngrese el nombre del producto: "); nombre_producto = Console.ReadLine();
            Console.Write("\tIngrese la cantidad vendida del producto: "); cantidad_vendida_producto = int.Parse(Console.ReadLine());
            Console.Write("\tIngrese el precio del producto: "); precio_producto = float.Parse(Console.ReadLine());
            Console.Write("\tPresione la tecla <ENTER o INTRO> para confirmar los valores");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();
            //Ejecución del método para calcular la venta
            ingresos_venta = Javier.CalcularVenta(cantidad_vendida_producto, precio_producto);
            //Ejecución del método desplegar venta
            Javier.DesplegarVenta(nombre_producto, cantidad_vendida_producto, precio_producto, ingresos_venta);
            //Mensaje final
            Console.Write("\tEl proceso ha terminado exitosamente.\n\tPresione la tecla <Esc> para salir...");
            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }
    }
}
