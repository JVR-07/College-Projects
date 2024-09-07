using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Declaración de librerias propias
using lbrLibros;

using CapturaDatos;

namespace Ejemplo_Librerias
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //Declaración de objeto para capturar datos
            CapturaDato Captura = new CapturaDato();

            //Declaración de variables auxiliares
            string titulo_libro, autor_libro;
            int numero_ejemplares_libro, numero_ejemplares_prestados_libro;
            bool libro_prestado, libro_devuelto;

            //Bienvenida
            Console.WriteLine("\n\t\t\t*** Bienvenido ***");
            Console.WriteLine("\n\tPara continuar ingrese los datos que se le piden.");

            //Captura de datos con métodos de biblioteca
            Console.WriteLine("\n");
            titulo_libro = CapturaDato.String("el título del libro");
            Console.WriteLine("\n");
            autor_libro = CapturaDato.String("el autor del libro");
            Console.WriteLine("\n");
            numero_ejemplares_libro = CapturaDato.Int("el número de ejemplares existentes");
            Console.WriteLine("\n");
            numero_ejemplares_prestados_libro = CapturaDato.Int("el número de libros prestados actualmente");
            Console.WriteLine("\n\tPROCESO TERMINADO EXITOSAMENTE.");
            Console.Write("\tPresione la tecla <Enter> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();

            //Creación de instancia de biblioteca
            Libros Libro1 = new Libros(titulo_libro,autor_libro,numero_ejemplares_libro,numero_ejemplares_prestados_libro);

            //LLamada a métodos
            Console.WriteLine("\t{0} es el autor del libro.",Libro1.ObtenerAutor());
            Console.WriteLine("\n");
            Console.WriteLine("\t{0} es el título del libro.",Libro1.ObtenerTitulo());
            Console.WriteLine("\n");
            Console.WriteLine("\tActualmente hay {0} ejemplares disponibles del libro {1}.",Libro1.ObtenerEjemplaresDisponibles(),Libro1.ObtenerTitulo());
            Console.WriteLine("\n");
            Console.WriteLine("\tActualmente se han prestado {0} ejemplares del libro {1}.",Libro1.ObtenerEjemplaresPrestados(),Libro1.ObtenerTitulo());
            Console.WriteLine("\n\tINFORMACIÓN MOSTRADA CORRECTAMENTE");
            Console.Write("\tPresione la tecla <Enter> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();

            //Segunda llamada a métodos
            Console.WriteLine("\n");
            libro_prestado = Libro1.PrestarEjemplar();
            if (libro_prestado)
            {
                Console.WriteLine("\tUn libro ha sido prestado.");
                Console.WriteLine("\tActualmente se han prestado {0} ejemplares del libro {1}.", Libro1.ObtenerEjemplaresPrestados(), Libro1.ObtenerTitulo());
            }
            else
            {
                Console.WriteLine("\tEl libro no ha sido prestado.");
                Console.WriteLine("\tSe han prestado todos los libros disponibles({0}).",Libro1.ObtenerEjemplaresPrestados());
            }
            Console.WriteLine("\n\n");
            libro_devuelto = Libro1.DevolverEjemplar();
            if (libro_devuelto)
            {
                Console.WriteLine("\tUn libro ha sido devuelto.");
                Console.WriteLine("\tActualmente se han prestado {0} ejemplares del libro {1}.", Libro1.ObtenerEjemplaresPrestados(), Libro1.ObtenerTitulo());
            }
            else
            {
                Console.WriteLine("\tNo se ha podido devolver el libro.");
                Console.WriteLine("\tNo se han prestado ejemplares del libro {0}.", Libro1.ObtenerTitulo());
            }
            Console.WriteLine("\n\tCÁLCULOS FINALIZADOS");
            Console.Write("\tPresione la tecla <Enter> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();

            //Tercera llamada a métodos
            Console.WriteLine("\n");
            Libro1.MostrarInformacionGeneral();
            Console.WriteLine("\n\tPROCESO TERMINADO");
            Console.Write("\tPresione la tecla <Esc> para cerrar el programa...");
            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }
    }
}