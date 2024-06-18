using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lbrLibros
{
    public class Libros
    {   //Campos de la clase
        private string titulo_libro, autor_libro;
        private int numero_ejemplares_libro, numero_ejemplares_prestados_libro;

        //Métodos de la clase

        //Método para mostrar información
        public void MostrarInformacionGeneral()
        {
            Console.WriteLine("\tTítulo Libro: " + this.titulo_libro + "\n\tAutor Libro: " + this.autor_libro +
                   "\n\tNúmero de Ejemplares Disponibles: " + this.numero_ejemplares_libro +
                   "\n\tNúmero de Ejemplares Prestados: " + this.numero_ejemplares_prestados_libro);
        }

        //Método para retornar el autor
        public string ObtenerAutor()
        {
            return this.autor_libro;
        }

        //Método para retornar el título
        public string ObtenerTitulo()
        {
            return this.titulo_libro;
        }

        //Método para retornar el número de libros actuales
        public int ObtenerEjemplaresDisponibles()
        {
            return this.numero_ejemplares_libro;
        }
        
        //Método para retornar el número de libros prestados
        public int ObtenerEjemplaresPrestados()
        {
            return this.numero_ejemplares_prestados_libro;
        }

        //Método para prestar libros
        public bool PrestarEjemplar()
        {
            bool prestar = true;
            if (this.numero_ejemplares_prestados_libro < this.numero_ejemplares_libro)
            {
                this.numero_ejemplares_prestados_libro++;
            }
            else
            {
                prestar = false;
            }
            return prestar;
        }

        //Método para devolver libros
        public bool DevolverEjemplar()
        {
            bool devuelto = true;
            if (this.numero_ejemplares_prestados_libro == 0)
            {
                devuelto = false;
            }
            else
            {
                this.numero_ejemplares_prestados_libro--;
                devuelto = true;
            }
            return devuelto;
        }

        //Constructores y destructores de la clase
        //Constructor
        public Libros(string titulo_libro, string autor_libro, int numero_ejemplares_libro, int numero_ejemplares_prestrados_libro)
        {
            this.titulo_libro = titulo_libro;
            this.autor_libro = autor_libro;
            this.numero_ejemplares_libro = numero_ejemplares_libro;
            this.numero_ejemplares_prestados_libro = numero_ejemplares_prestrados_libro;
        }
        //Destructor
        ~Libros()
        {
            Console.WriteLine("\n\tMemoria Liberada del objeto libro " + this.titulo_libro);
        }
    }
}