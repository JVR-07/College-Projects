using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa43_Practica_ArchivoBinarioVeterinaria
{
    internal class Program
    {
        class Veterinaria
        {
            //Campos de la clase
            string nombre_mascota, raza_mascota, color_mascota, padecimiento_mascota;
            short edad_mascota, dias_hospitalizado_mascota;
            float costo_diario_mascota;

            //Declaración de flujos
            FileStream fs = null;
            BinaryReader br = null;
            BinaryWriter bw = null;

            //Métodos de la clase
            public void CrearArchivo(string nombre_archivo)
            {   //Declaración de variables auxiliares
                char opcion = ' ';

                do
                {
                    if (File.Exists(nombre_archivo))
                    {
                        try
                        {
                            try
                            {
                                Console.WriteLine("\n\t\t.: ESCRITURA DE REGISTROS :.");
                                Console.Write("\n\tSe ha detectado un archivo con el mismo nombre." +
                                              "\n\t¿Qué operación desea realizar?" +

                                              "\n\n\tA) Reemplazar el archivo" +
                                                "\n\tB) Añadir nuevo registro" +
                                                "\n\tC) Regresar al menú" +

                                                "\n\n\tIngrese la letra de la opción deseada: "); opcion = char.ToUpper(char.Parse(Console.ReadLine()));
                                Console.Write("\n\n\tEl dato ha sido capturado correctamente." +
                                                 "\n\tPresione la tecla <Enter> para continuar...");
                                Console.ReadKey(); Console.Clear();
                            }
                            catch (FormatException e)
                            {
                                Console.Clear();
                                Console.WriteLine("\n\t\t.: HA OCURRIDO UN ERROR :.");
                                Console.WriteLine("\n\tMensaje de error: {0}", e.Message);
                            }
                            switch (opcion)
                            {
                            case 'A': 
                                {
                                    //Creación de flujo
                                    this.fs = new FileStream(nombre_archivo, FileMode.Create, FileAccess.Write);
                                    //Creación de escritor binario
                                    bw = new BinaryWriter(this.fs);
                                    do
                                    {
                                        Console.WriteLine("\n\t\t.: ESCRITURA DE REGISTROS :.");

                                        //captura de datos
                                        Console.Write("\n\tIngrese el nombre de la mascota: "); nombre_mascota = Console.ReadLine();
                                        Console.Write("\n\tIngrese la raza de la mascota: "); raza_mascota = Console.ReadLine();
                                        Console.Write("\n\tIngrese el color de la mascota: "); color_mascota = Console.ReadLine();
                                        Console.Write("\n\tIngrese la edad de la mascota: "); edad_mascota = short.Parse(Console.ReadLine());
                                        Console.Write("\n\tIngrese el padecimiento de la mascota: "); padecimiento_mascota = Console.ReadLine();
                                        Console.Write("\n\tIngrese los días que estará hospitalizada la mascota: "); dias_hospitalizado_mascota = short.Parse(Console.ReadLine());
                                        Console.Write("\n\tIngrese el costo diario por hospitalización: "); costo_diario_mascota = float.Parse(Console.ReadLine());

                                        bw.Write(nombre_mascota);
                                        bw.Write(raza_mascota);
                                        bw.Write(color_mascota);
                                        bw.Write(edad_mascota);
                                        bw.Write(padecimiento_mascota);
                                        bw.Write(dias_hospitalizado_mascota);
                                        bw.Write(costo_diario_mascota);

                                        Console.Write("\n\t¿Desea realizar otro registro? s | n : "); opcion = char.ToLower(char.Parse(Console.ReadLine()));
                                        if (opcion == 's') 
                                        {
                                            Console.Write("\n\tDatos escritos correctamente" +
                                                          "\n\tPresione la tecla <Enter> para iniciar otro registro...");
                                            Console.ReadLine(); Console.Clear();
                                        }
                                        else if(opcion == 'n')
                                        {
                                            Console.Write("\n\tDatos escritos correctamente" +
                                                          "\n\tPresione la tecla <Enter> para regresar al menú...");
                                            Console.ReadLine(); Console.Clear();
                                            opcion = 'C';
                                        }
                                        else
                                        {
                                            Console.Write("\n\tLa respuesta no ha sido válida, será regresado al menú" +
                                                          "\n\tPresione la tecla <Enter> para continuar...");
                                            Console.ReadLine(); Console.Clear();
                                            opcion = 'C';
                                        } 
                                    }
                                    while (opcion != 'C');
                                        bw.Close();
                                        fs.Close();
                                }
                                break;
                            case 'B':
                                {
                                    //Creación de flujo
                                    this.fs = new FileStream(nombre_archivo, FileMode.Append, FileAccess.Write);
                                    //Creación de escritor binario
                                    bw = new BinaryWriter(this.fs);

                                    do
                                    {
                                        Console.WriteLine("\n\t\t.: ESCRITURA DE REGISTROS :.");

                                        //captura de datos
                                        Console.Write("\n\tIngrese el nombre de la mascota: "); nombre_mascota = Console.ReadLine();
                                        Console.Write("\n\tIngrese la raza de la mascota: "); raza_mascota = Console.ReadLine();
                                        Console.Write("\n\tIngrese el color de la mascota: "); color_mascota = Console.ReadLine();
                                        Console.Write("\n\tIngrese la edad de la mascota: "); edad_mascota = short.Parse(Console.ReadLine());
                                        Console.Write("\n\tIngrese el padecimiento de la mascota: "); padecimiento_mascota = Console.ReadLine();
                                        Console.Write("\n\tIngrese los días que estará hospitalizada la mascota: "); dias_hospitalizado_mascota = short.Parse(Console.ReadLine());
                                        Console.Write("\n\tIngrese el costo diario por hospitalización: "); costo_diario_mascota = float.Parse(Console.ReadLine());

                                        bw.Write(nombre_mascota);
                                        bw.Write(raza_mascota);
                                        bw.Write(color_mascota);
                                        bw.Write(edad_mascota);
                                        bw.Write(padecimiento_mascota);
                                        bw.Write(dias_hospitalizado_mascota);
                                        bw.Write(costo_diario_mascota);

                                        Console.Write("\n\t¿Desea realizar otro registro? s | n : "); opcion = char.ToLower(char.Parse(Console.ReadLine()));
                                        if (opcion == 's')
                                        {
                                            Console.Write("\n\tDatos escritos correctamente" +
                                                          "\n\tPresione la tecla <Enter> para iniciar otro registro...");
                                            Console.ReadLine(); Console.Clear();
                                        }
                                        else if (opcion == 'n')
                                        {
                                            Console.Write("\n\tDatos escritos correctamente" +
                                                          "\n\tPresione la tecla <Enter> para regresar al menú...");
                                            Console.ReadLine(); Console.Clear();
                                            opcion = 'C';
                                        }
                                        else
                                        {
                                            Console.Write("\n\tLa respuesta no ha sido válida, será regresado al menú" +
                                                          "\n\tPresione la tecla <Enter> para continuar...");
                                            Console.ReadLine(); Console.Clear();
                                            opcion = 'C';
                                        }
                                    }
                                    while (opcion != 'C');
                                        bw.Close();
                                        fs.Close();
                                    }
                                break;
                            case 'C': 
                                {
                                    Console.WriteLine("\n\t\t.: REGRESANDO AL MENÚ :.");
                                    Console.Write("\n\tEscritura finalizada correctamente" +
                                                  "\n\tPresione la tecla <Enter> para regresar al menú...");
                                    Console.ReadLine(); Console.Clear();
                                } 
                                break;
                            default: 
                                {
                                    Console.WriteLine("\n\t\t.: ALGO HA SALIDO MAL :.");
                                    Console.Write("\n\tLa opción ingresada no existe" +
                                                  "\n\tPresione la tecla <Enter> para intentarlo de nuevo...");
                                    Console.ReadLine(); Console.Clear();
                                }
                                break;
                            }
                        }
                        catch (ArgumentOutOfRangeException e)
                        {
                            Console.Clear();
                            Console.WriteLine("\n\t\t.: HA OCURRIDO UN ERROR :.");
                            Console.WriteLine("\n\tMensaje de error: {0}" +
                                              "\n\tProducido en {1}", e.Message, e.StackTrace);
                        }
                        catch (FormatException e)
                        {
                            Console.Clear();
                            Console.WriteLine("\n\t\t.: HA OCURRIDO UN ERROR :.");
                            Console.WriteLine("\n\tMensaje de error: {0}" +
                                              "\n\tProducido en {1}", e.Message, e.StackTrace);
                            Console.Write("\n\tPresione la tecla <Enter> para intentarlo de nuevo...");
                            Console.ReadLine(); Console.Clear();
                        }
                        catch (OverflowException e)
                        {
                            Console.Clear();
                            Console.WriteLine("\n\t\t.: HA OCURRIDO UN ERROR :.");
                            Console.WriteLine("\n\tMensaje de error: {0}" +
                                              "\n\tProducido en {1}", e.Message, e.StackTrace);
                            Console.Write("\n\tPresione la tecla <Enter> para intentarlo de nuevo...");
                            Console.ReadLine(); Console.Clear();
                        }
                    }

                    else
                    {
                        //Creación de flujo
                        this.fs = new FileStream(nombre_archivo, FileMode.Create, FileAccess.Write);
                        //Creación de escritor binario
                        bw = new BinaryWriter(this.fs);
                        
                        do
                        {
                            try
                            {
                                Console.WriteLine("\n\t\t.: ESCRITURA DE REGISTROS :.");


                                //captura de datos
                                Console.Write("\n\tIngrese el nombre de la mascota: "); nombre_mascota = Console.ReadLine();
                                Console.Write("\n\tIngrese la raza de la mascota: "); raza_mascota = Console.ReadLine();
                                Console.Write("\n\tIngrese el color de la mascota: "); color_mascota = Console.ReadLine();
                                Console.Write("\n\tIngrese la edad de la mascota: "); edad_mascota = short.Parse(Console.ReadLine());
                                Console.Write("\n\tIngrese el padecimiento de la mascota: "); padecimiento_mascota = Console.ReadLine();
                                Console.Write("\n\tIngrese los días que estará hospitalizada la mascota: "); dias_hospitalizado_mascota = short.Parse(Console.ReadLine());
                                Console.Write("\n\tIngrese el costo diario por hospitalización: "); costo_diario_mascota = float.Parse(Console.ReadLine());

                                bw.Write(nombre_mascota);
                                bw.Write(raza_mascota);
                                bw.Write(color_mascota);
                                bw.Write(edad_mascota);
                                bw.Write(padecimiento_mascota);
                                bw.Write(dias_hospitalizado_mascota);
                                bw.Write(costo_diario_mascota);

                                Console.Write("\n\t¿Desea realizar otro registro? s | n : "); opcion = char.ToLower(char.Parse(Console.ReadLine()));
                                if (opcion == 's')
                                {
                                    Console.Write("\n\tDatos escritos correctamente" +
                                                  "\n\tPresione la tecla <Enter> para iniciar otro registro...");
                                    Console.ReadLine(); Console.Clear();
                                }
                                else if (opcion == 'n')
                                {
                                    Console.Write("\n\tDatos escritos correctamente" +
                                                  "\n\tPresione la tecla <Enter> para regresar al menú...");
                                    Console.ReadLine(); Console.Clear();
                                    opcion = 'C';
                                    bw.Close();
                                    fs.Close();
                                }
                                else
                                {
                                    Console.Write("\n\tLa respuesta no ha sido válida, será regresado al menú" +
                                                  "\n\tPresione la tecla <Enter> para continuar...");
                                    Console.ReadLine(); Console.Clear();
                                    opcion = 'C';
                                    bw.Close();
                                    fs.Close();
                                }
                            }
                            catch (ArgumentOutOfRangeException e)
                            {
                                Console.Clear();
                                Console.WriteLine("\n\t\t.: HA OCURRIDO UN ERROR :.");
                                Console.WriteLine("\n\tMensaje de error: {0}" +
                                                  "\n\tProducido en {1}", e.Message, e.StackTrace);
                            }
                            catch (FormatException e)
                            {
                                Console.Clear();
                                Console.WriteLine("\n\t\t.: HA OCURRIDO UN ERROR :.");
                                Console.WriteLine("\n\tMensaje de error: {0}" +
                                                  "\n\tProducido en {1}", e.Message, e.StackTrace);
                                Console.Write("\n\tPresione la tecla <Enter> para intentarlo de nuevo...");
                                Console.ReadLine(); Console.Clear();
                            }
                            catch (OverflowException e)
                            {
                                Console.Clear();
                                Console.WriteLine("\n\t\t.: HA OCURRIDO UN ERROR :.");
                                Console.WriteLine("\n\tMensaje de error: {0}" +
                                                  "\n\tProducido en {1}", e.Message, e.StackTrace);
                                Console.Write("\n\tPresione la tecla <Enter> para intentarlo de nuevo...");
                                Console.ReadLine(); Console.Clear();
                            }
                        }
                        while (opcion != 'C');
                    }
                } while (opcion != 'C');
                
            }

            public void LeerArchivo(string nombre_archivo)
            {

                Console.WriteLine("\n\t\t.: LECTURA DE REGISTROS :.");

                //Creación de flujo
                this.fs = new FileStream(nombre_archivo, FileMode.Open, FileAccess.Read);
                //Creación de escritor binario
                br = new BinaryReader(this.fs);
                try
                {
                    if (File.Exists(nombre_archivo))
                    {
                        do
                        {
                            
                            Console.WriteLine("\n\tNombre: {0}", br.ReadString());
                            Console.WriteLine("\n\tRaza: {0}", br.ReadString());
                            Console.WriteLine("\n\tColor: {0}", br.ReadString());
                            Console.WriteLine("\n\tEdad: {0}", br.ReadInt16());
                            Console.WriteLine("\n\tPadecimiento: {0}", br.ReadString());
                            dias_hospitalizado_mascota = br.ReadInt16();
                            Console.WriteLine("\n\tDías en hospitalización: {0}",dias_hospitalizado_mascota);
                            costo_diario_mascota = br.ReadSingle();
                            Console.WriteLine("\n\tCosto diario por hospitalización: {0:C}",costo_diario_mascota);
                            Console.WriteLine("\n\tCosto total por hospitalización: {0:C}", dias_hospitalizado_mascota * costo_diario_mascota);
                            Console.WriteLine("\n");
                        } while (true);
                    }
                    else
                    {
                        throw new FileNotFoundException();
                    }
                }
                catch (EndOfStreamException)
                {
                    Console.Write("\n\tLectura finalizada, presione la tecla <Enter> para regresar al menú...");
                    Console.ReadLine(); Console.Clear();
                    br.Close();
                    fs.Close();
                }
                catch (FileNotFoundException e)
                {
                    Console.Clear();
                    Console.WriteLine("\n\t\t.: HA OCURRIDO UN ERROR :.");
                    Console.WriteLine("\n\tMensaje de error: {0}" +
                                      "\n\tProducido en {1}", e.Message, e.StackTrace);
                }
            }
            //destructor
            ~Veterinaria()
            {
                Console.WriteLine("Memoria Liberada del objeto Veterinaria");
            }
        }
        static void Main(string[] args)
        {
            //Declaración de variables auxiliares
            char opcion = ' ';
            string nombre_archivo;

            //Creación de objeto
            Veterinaria Vet = new Veterinaria();

            do
            {
                try
                {
                    Console.WriteLine("\n\t      .: MENÚ VETERINARIA :.");
                    Console.WriteLine("\n\t| Estas son las opciones disponibles |");
                    Console.WriteLine("\n\ta) = Crear archivo" +
                                      "\n\tb) = Leer archivo" +
                                      "\n\tc) = Salir del programa");
                    Console.Write("\n\tIngrese la letra de la opción deseada: "); opcion = char.ToLower(char.Parse(Console.ReadLine()));
                    Console.Clear();
                }
                catch (FormatException e)
                {
                    Console.Clear();
                    Console.WriteLine("\n\t\t.: HA OCURRIDO UN ERROR :.");
                    Console.WriteLine("\n\tMensaje de error: {0}", e.Message);
                }
                switch (opcion)
                {
                    case 'a': 
                        {
                            Console.WriteLine("\n\t\t\t.: BUSCANDO ARCHIVO :.");
                            Console.Write("\n\tIngrese el nombre del archivo: ");   nombre_archivo = Console.ReadLine();
                            Console.Write("\n\tDato capturado correctamente" +
                                              "\n\tPresione la tecla <Enter> para continuar...");
                            Console.ReadKey(); Console.Clear();

                            //Llamada a método para escribir archivo
                            Vet.CrearArchivo(nombre_archivo);
                        }
                        break;
                    case 'b': 
                        {
                            Console.WriteLine("\n\t\t\t.: BUSCANDO ARCHIVO :.");
                            Console.Write("\n\tIngrese el nombre del archivo: "); nombre_archivo = Console.ReadLine();
                            Console.Write("\n\tDato capturado correctamente" +
                                              "\n\tPresione la tecla <Enter> para continuar...");
                            Console.ReadKey(); Console.Clear();

                            //Llamada a método para escribir archivo
                            Vet.LeerArchivo(nombre_archivo);
                        }
                        break;
                    case'c': 
                        {
                            Console.WriteLine("\n\t\t\t.: BUSCANDO ARCHIVO :.");
                            Console.WriteLine("\n\tGracias por usar nuestro software, regrese pronto");
                            Console.Write("\n\tPresione la tecla <Esc> para salir...");
                            Console.ReadKey();
                        }
                        break;
                    default: 
                        {
                            Console.WriteLine("\n\t\t.: ALGO HA SALIDO MAL :.");
                            Console.Write("\n\tLa opción ingresada no existe" +
                                          "\n\tPresione la tecla <Enter> para intentarlo de nuevo...");
                            Console.ReadLine(); Console.Clear();
                        }
                        break;
                }
            } while (opcion != 'c');
        }
    }
}