using System; // Referencia a librerias
using System.Collections.Generic; // Referencia a librerias
using System.Linq; // Referencia a librerias 
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text; // Referencia a librerias
using System.Threading.Tasks; // Referencia a librerias

// Practica de laboratorio. Desplegando Mensajes
// Machado Sanchez Javier 22211600
/* Uso de:  
   - Write, WriteLine
   - ReadKey, ReadLine
   - ForegroundColor, BackgroundColor 
   - Comentario de una o varias lineas 
*/   
namespace Mostrar_Consola // Nombre de proyecto
{
    internal class Program
    {
        static void Main(string[] args) // Metodo en donde inicia el arranque del programa
        {
            Console.BackgroundColor = ConsoleColor.Gray; // Cambio de color de fondo de consola
            Console.Clear(); // Limpia el color de fondo y acepta nuevo color
            Console.ForegroundColor = ConsoleColor.Green; // Cambio de color de fuente
            Console.WriteLine("**** HELLO WORD ****"); // Muestra mensaje
            Console.ForegroundColor = ConsoleColor.White; // Cambio de color de fuente
            Console.WriteLine("**** HELLO WORD ****"); // Muestra mensaje
            Console.ForegroundColor = ConsoleColor.Red; // Cambio de color de fuente
            Console.WriteLine("**** HELLO WORD ****"); // Muestra mensaje 
            Console.ReadKey();
            // Permite que la consola no se cierre hasta presionar una tecla
        }
    }
}
