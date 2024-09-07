using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_MachadoJavier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            Console.Write("\tNúmero 1: "); num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n\tNúmero 2: "); num2 = Convert.ToDouble(Console.ReadLine());

            Operacion OpAritmetica = new Operacion(num1, num2);

            Console.WriteLine("\n\tResultados");
            Console.WriteLine($"Suma: {OpAritmetica.Suma()}");
            Console.WriteLine($"Resta: {OpAritmetica.Resta()}");
            Console.WriteLine($"Multiplicación: {OpAritmetica.Multiplicacion()}");
            Console.WriteLine($"División: {OpAritmetica.Division()}");

            Console.ReadKey();
        }
    }
    public class Operacion
    {
        private double primer_numero, segundo_numero;

        public Operacion(double primer_numero, double segundo_numero)
        {
            this.primer_numero = primer_numero;
            this.segundo_numero = segundo_numero;
        }

        public double Suma()
        {
            return primer_numero + segundo_numero;
        }

        public double Resta()
        {
            return primer_numero - segundo_numero;
        }

        public double Multiplicacion()
        {
            return primer_numero * segundo_numero;
        }

        public double Division()
        {
            return primer_numero / segundo_numero;
        }
    }
}
