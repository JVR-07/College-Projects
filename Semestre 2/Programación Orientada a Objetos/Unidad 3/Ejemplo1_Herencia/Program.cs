using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1_Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Despliegue de mensajes
            Console.WriteLine("\t\t*** Bienvenido ***");
            Console.WriteLine("Este es un programa ejemplo de herencia, los datos han sido cargados previamente.");
            Console.Write("\nPresione la tecla <Enter> para comenzar con las operaciones...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();
            //Utilización de constructor de la clase derivada
            clsAracnidos Salticidae_Maratus = new clsAracnidos("Salticidae Maratus", "Blanco", "Llamativo con colores vivos", 2, 8, 5, 1.5f, 7, false, true);
            //Llamada a métodos tanto de la clase derivada como de la clase base
            Salticidae_Maratus.Caminar();
            Salticidae_Maratus.CrearTelaraña();
            Salticidae_Maratus.Morder();
            Salticidae_Maratus.Mudar();
            Salticidae_Maratus.Cortejo();
            Salticidae_Maratus.Reproducirse();
            Salticidae_Maratus.Descansar();
            Console.Write("\nPresione la tecla <Enter> para mostrar la información...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();
            Salticidae_Maratus.DespliegueInformacion();
            //Mensaje final
            Console.Write("\nEl proceso ha finalizado.\nPresione la tecla <Esc> para salir...");
            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }
    }
}