using System; // Referencia a librerias 
using System.Collections.Generic; // Referencia a librerias 
using System.Linq; // Referencia a librerias 
using System.Text; // Referencia a librerias 
using System.Threading.Tasks; // Referencia a librerias 

//Machado Sanchez Javier 22211600
// Problema #9 a código C#
// ~Mostrar el nombre de la ciudad que el usuario desee.~

namespace Problema_9 // Nombre del proyecto
{
    internal class Program
    {
        static void Main(string[] args) // Metodo de arranque del programa
        {
            string city; // El tipo de dato 'String' almacena cadenas de caracteres
            Console.BackgroundColor = ConsoleColor.White; // Color de Fondo
            Console.Clear(); // Limpia el color de la consola y permite nuevo color 
            Console.ForegroundColor = ConsoleColor.DarkGray; // Color de fuente
            Console.WriteLine("Por favor, ingrese el nombre de su ciudad favorita: "); // Mostrar mensaje
            city = Console.ReadLine(); // Leer dato del usuario
            Console.ForegroundColor = ConsoleColor.Blue; // Color de fuente
            Console.WriteLine("El nombre de su ciudad favorita es: " + city); // Mostrar mensaje y nombre de la ciudad
            Console.ReadKey(); // Permite mantener abierta la consola hasta que se presione una tecla
        }
    }
}
