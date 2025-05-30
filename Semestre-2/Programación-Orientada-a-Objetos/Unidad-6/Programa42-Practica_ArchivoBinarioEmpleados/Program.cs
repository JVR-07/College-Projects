﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa42_Practica_ArchivoBinarioEmpleados
{
    internal class Program
    {
        class ArchivoBinarioEmpleados
        {
            //declaracion de flujos
            BinaryWriter bw = null; //flujo salida - escritura de datos
            BinaryReader br = null; //flujo entrada - lectura de datos
            
            //campos de la clase
            string Nombre, Direccion, NomArch;
            long Telefono;
            int NumEmp;
            short DiasTrabajados;
            float SalarioDiario;
            
            public void CrearArchivo(string Archivo)
            {
                NomArch = Archivo;
                char resp = ' '; //variable local método
                try
                {
                    //creación del flujo para escribir datos al archivo
                        bw = new BinaryWriter(new FileStream(Archivo,
                        FileMode.Create, FileAccess.Write));

                    //captura de datos
                    do
                    {
                        Console.Clear();
                        try
                        {
                            Console.Write("Numero del Empleado: "); NumEmp = Int32.Parse(Console.ReadLine());
                            Console.Write("Nombre del Empleado: "); Nombre = Console.ReadLine();
                            Console.Write("Dirección del Empleado: "); Direccion = Console.ReadLine();
                            Console.Write("Teléfono del Empleado: "); Telefono = Int64.Parse(Console.ReadLine());
                            Console.Write("Dias Trabajados del Empleado: "); DiasTrabajados = Int16.Parse(Console.ReadLine());
                            Console.Write("Salario Diario del Empleado: "); SalarioDiario = Single.Parse(Console.ReadLine());
                        
                            //escribe los datos al archivo en disco
                            bw.Write(NumEmp);
                            bw.Write(Nombre);
                            bw.Write(Direccion);
                            bw.Write(Telefono);
                            bw.Write(DiasTrabajados);
                            bw.Write(SalarioDiario);
                            Console.Write("\n\nDeseas Almacenar otro Registro (s/n) ? ");
                            resp = char.ToLower(Char.Parse(Console.ReadLine()));
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine("\nError : " + e.Message);

                            Console.WriteLine("\nRuta : " + e.StackTrace);
                        }
                    } while (resp == 's');
                }
                
                catch (IOException es)
                {
                    Console.WriteLine("\nError : " + es.Message);
                    Console.WriteLine("\nRuta : " + es.StackTrace);
                }
                finally
                {
                    if (bw != null) bw.Close(); //cierra flujo escritura
                    Console.Write("\nPresione <enter> para terminar la Escritura de Datos y regresar al Menu.");
                    Console.ReadKey();
                }
            }

            public void MostrarArchivo(string Archivo)
            {
                NomArch = Archivo;
                try
                {
                    //verifica si existe el archivo
                    if (File.Exists(Archivo))
                    {
                        //creación flujo para leer datos del archivo
                        br = new BinaryReader(new FileStream(Archivo,
                        FileMode.Open, FileAccess.Read));
                            
                        //despliegue de datos en pantalla
                        Console.Clear();
                        do
                        {
                            //lectura de registros mientras no llegue al EndOfFile
                            NumEmp = br.ReadInt32();
                            Nombre = br.ReadString();
                            Direccion = br.ReadString();
                            Telefono = br.ReadInt64();
                            DiasTrabajados = br.ReadInt16();
                            SalarioDiario = br.ReadSingle();

                            //muestra los datos en pantalla

                            Console.WriteLine("Numero del Empleado : " + NumEmp);
                            Console.WriteLine("Nombre del Empleado : " + Nombre);
                            Console.WriteLine("Dirección del Empleado : " + Direccion);
                            Console.WriteLine("Teléfono del Empleado : " + Telefono);
                            Console.WriteLine("Dias Trabajados del Empleado : " + DiasTrabajados);
                            Console.WriteLine("Salario Diario del Empleado : {0:C}",SalarioDiario);
                            Console.WriteLine("SUELDO TOTAL del Empleado : {0:C}",DiasTrabajados*SalarioDiario);
                            Console.WriteLine("\n");
                        } while (true);
                    }
                    else
                    {
                        Console.Clear();

                        Console.WriteLine("\n\nEl Archivo " + Archivo + " No Existe en el Disco!!");
                        Console.Write("\nPresione <enter> para Continuar...");
                        Console.ReadKey();
                    }
                }

                catch (EndOfStreamException)
                {
                    Console.WriteLine("\n\nFin del Listado de Empleados");
                    Console.Write("\nPresione <enter> para Continuar...");
                    Console.ReadKey();
                }
                finally
                {
                    if (br != null) br.Close(); //cierra flujo lectura
                    Console.Write("\nPresione <enter> para terminar la Lectura de Datos y regresar al Menu.");
                    Console.ReadKey();
                }
            }
            ~ArchivoBinarioEmpleados()
            {
                Console.WriteLine("\nMemoria Liberada Archivo Binario: " + this.NomArch);
            }
        }
        static void Main(string[] args)
        {   //declaración variables auxiliares
            string Arch = null;
            short opcion = 0;
            //creación del objeto
            ArchivoBinarioEmpleados A1 = new ArchivoBinarioEmpleados();
            //Menu de Opciones
            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("\n*** ARCHIVO BINARIO EMPLEADOS***");
                    Console.WriteLine("1.- Creación de un Archivo.");
                    Console.WriteLine("2.- Lectura de un Archivo.");
                    Console.WriteLine("3.- Salida del Programa.");
                    Console.Write("\nQue opción deseas: ");
                    opcion = Int16.Parse(Console.ReadLine());
                }
                catch(FormatException e)
                {
                    Console.WriteLine("\nError : " + e.Message);

                    Console.WriteLine("\nRuta : " + e.StackTrace);
                    opcion = 0;
                }

                switch (opcion)
                {
                    case 1:
                        //bloque de escritura
                        try
                        {
                            //captura nombre archivo
                            Console.Write("\nAlimenta el Nombre del Archivo a Crear: "); Arch = Console.ReadLine();
                            if(Arch == " ") { throw new ArgumentException(); }
                            
                            //verifica si esxiste el archivo
                            char resp = 's';
                            if (File.Exists(Arch))
                            {
                                Console.Write("\nEl Archivo Existe!!, Deseas Sobreescribirlo(s / n) ? ");
                                resp = char.ToLower(Char.Parse(Console.ReadLine()));
                            }
                            if (resp == 's')
                                A1.CrearArchivo(Arch);
                        }
                        catch (IOException e)
                        {
                            Console.WriteLine("\nError : " + e.Message);

                            Console.WriteLine("\nRuta : " + e.StackTrace);
                            Console.WriteLine("\nPresione la tecla <Enter> para oontinuar...");
                            Console.ReadKey();
                        }
                        catch (ArgumentException e)
                        {
                            Console.WriteLine("\nError : " + e.Message);

                            Console.WriteLine("\nRuta : " + e.StackTrace);
                            Console.WriteLine("\nPresione la tecla <Enter> para oontinuar...");
                            Console.ReadKey();
                        }
                        break;
                    case 2:
                        //bloque de lectura
                        try
                        {
                            //captura nombre archivo
                            Console.Write("\nAlimenta el Nombre del Archivo que deseas Leer: "); Arch = Console.ReadLine();
                            A1.MostrarArchivo(Arch);
                        }
                        catch (IOException e)
                        {
                            Console.WriteLine("\nError : " + e.Message);

                            Console.WriteLine("\nRuta : " + e.StackTrace);
                        }
                        break;
                    case 3:
                        Console.Write("\nPresione <enter> para Salir del Programa.");
                        Console.ReadKey();
                        break;
                    default:
                        Console.Write("\nEsa Opción No Existe!!, Presione <enter> para Continuar...");
                        Console.ReadKey();
                        break;
                }
            } while (opcion != 3);
        }
    }
}
