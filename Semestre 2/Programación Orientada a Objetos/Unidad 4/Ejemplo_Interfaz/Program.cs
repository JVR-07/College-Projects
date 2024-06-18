using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Interfaz
{
    internal class Program
    {
        //Declaración de variables auxiliares para captura de datos
        static char CapturaChar(string texto_pantalla)
        {
            Console.Write("Ingrese {0} : ", texto_pantalla);
            return char.Parse(Console.ReadLine());
        }
        static string CapturaString(string texto_pantalla)
        {
            Console.Write("Ingrese {0} : ", texto_pantalla);
            return Console.ReadLine();
        }
        static short CapturaShort(string texto_pantalla)
        {
            Console.Write("Ingrese {0} : ", texto_pantalla);
            return short.Parse(Console.ReadLine());
        }
        static int CapturaInt(string texto_pantalla)
        {
            Console.Write("Ingrese {0} : ", texto_pantalla);
            return int.Parse(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            //Declaración de variables auxiliares para avisos en general
            string mensaje, fecha;

            //Declaración de variables auxiliares para avisos gubernamentales y derivadas
            char aux_sexo;
            string nombre_destinatario, curp_destinatario, firma_electronica, rfc_destinatario;
            bool sexo_masculino = false;

            //Declaración de variables auxiliares para avisos escolares y derivadas
            string nombre_alumno, fecha_cancelacion, fecha_innovatec;
            int numero_control_alumno;
            bool alumno_es_hombre = false;

            //Declaración de variables auxiliares
            short aux_tipo_aviso, aux_tipo_aviso_gubernamental, aux_tipo_aviso_escolar, aux_tipo_aviso_servicios_escolares;
            bool aux_ejecucion = true, aux_menu_tipo_avisos_gob = true, aux_menu_tipo_avisos_esc = true, aux_menu_servicios_escolares = true, aux_menu_sistemas = true;

            do //Do while para controlar el menú general
            {
                // Despliegue de menú general
                Console.WriteLine("\t\t*** ¿Que tipo de aviso es? ***");
                Console.WriteLine("\n1 - Aviso Gubernamental.\n2 - Aviso Escolar\n3 - Salir del programa");

                //Captura de datos
                aux_tipo_aviso = CapturaShort("el número del tipo de aviso deseado");
                Console.WriteLine("Opción registrada");
                Console.Write("Presione la tecla <Enter> para continuar...");
                while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                Console.Clear();
                switch (aux_tipo_aviso) // Switch case para controlar las opciones
                {
                    case 1: // Aviso Gubernamental
                        {
                            do // Do while para controlar menú de avisos gubernamentales
                            {   
                                //Despliegue de menú de avisos gubernamentales
                                Console.WriteLine("\t\t*** Aviso Gubernamental ***");
                                Console.WriteLine("\n¿Qué tipo de aviso deseas enviar?");
                                Console.WriteLine("\n1 - Aviso de Tráfico\n2 - Aviso de Hacienda\n3 - Salir del programa");

                                //Captura de datos
                                aux_tipo_aviso_gubernamental = CapturaShort("el número del tipo de aviso deseado");
                                Console.WriteLine("Opción registrada");
                                Console.Write("Presione la tecla <Enter> para continuar...");
                                while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                                Console.Clear();
                                switch (aux_tipo_aviso_gubernamental) // Switch case para controlar las opciones
                                {
                                    case 1: // Aviso de Tráfico
                                        {
                                            //Captura de datos
                                            Console.WriteLine("*** Aviso de Tráfico ***");
                                            Console.WriteLine("\nCapture los datos que se le pidan");
                                            mensaje = CapturaString("el mensaje que se enviará");
                                            fecha = CapturaString("la fecha en la que se enviará");
                                            nombre_destinatario = CapturaString("el nombre del destinatario");
                                            curp_destinatario = CapturaString("el curp del destinatario");
                                            Console.WriteLine("¿Qué sexo tiene el destinatario? H | M" +
                                                              "\nIngrese en MAYÚSCULAS la letra de la opción deseada" +
                                                              "\nGlosario(H = Hombre, M = Mujer)");
                                            aux_sexo = CapturaChar("su respuesta aquí");
                                            switch (aux_sexo)
                                            {
                                                case 'H':
                                                    {
                                                        sexo_masculino = true;
                                                    }
                                                    break;
                                                case 'M':
                                                    {
                                                        sexo_masculino = false;
                                                    }
                                                    break;
                                                default:
                                                    {
                                                        Console.WriteLine("La opción ingresada no es válida. El proceso se reiniciará");
                                                        Console.Write("Presione la tecla <Enter> para continuar...");
                                                        while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                                                        Console.Clear();
                                                    }
                                                    break;
                                            }
                                            //Creación del objeto
                                            clsAvisosTrafico InfraccionTrafico = new clsAvisosTrafico(mensaje, fecha, nombre_destinatario, curp_destinatario, sexo_masculino);
                                            Console.WriteLine("Proceso de registo terminado");
                                            Console.Write("Presione la tecla <Enter> para continuar...");
                                            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                                            Console.Clear();
                                            
                                            //Llamada a método
                                            Console.WriteLine("\t\t*** Despliegue de aviso ***\n");
                                            InfraccionTrafico.MostrarAviso();
                                            Console.Write("\n\t*** Firma de recibido ***\n");
                                            firma_electronica = CapturaString("una palabra o frase");
                                            Console.WriteLine("\n");
                                            InfraccionTrafico.FirmaRecibido(firma_electronica);
                                            Console.WriteLine("Mensaje enviado correctamente");
                                            Console.Write("Presione la tecla <Enter> para continuar...");
                                            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                                            Console.Clear() ;
                                        }
                                        break;
                                    case 2: // Aviso de Hacienda
                                        {
                                            //Captura de datos
                                            Console.WriteLine("*** Aviso de Hacienda ***");
                                            Console.WriteLine("\nCapture los datos que se le pidan");
                                            mensaje = CapturaString("el mensaje que se enviará");
                                            rfc_destinatario = CapturaString("el rfc del destinatario");
                                            fecha = CapturaString("la fecha en la que se enviará");
                                            nombre_destinatario = CapturaString("el nombre del destinatario");
                                            curp_destinatario = CapturaString("el curp del destinatario");
                                            Console.WriteLine("¿Qué sexo tiene el destinatario? H | M" +
                                                              "\nIngrese en MAYÚSCULAS la letra de la opción deseada" +
                                                              "\nGlosario(H = Hombre, M = Mujer)");
                                            aux_sexo = CapturaChar("su respuesta aquí");
                                            switch (aux_sexo)
                                            {
                                                case 'H':
                                                    {
                                                        sexo_masculino = true;
                                                    }
                                                    break;
                                                case 'M':
                                                    {
                                                        sexo_masculino = false;
                                                    }
                                                    break;
                                                default:
                                                    {
                                                        Console.WriteLine("La opción ingresada no es válida. El proceso se reiniciará");
                                                        Console.Write("Presione la tecla <Enter> para continuar...");
                                                        while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                                                        Console.Clear();
                                                    }
                                                    break;
                                            }
                                            //Creación del objeto
                                            clsAvisosHacienda InfraccionHacienda = new clsAvisosHacienda(mensaje, rfc_destinatario, fecha, nombre_destinatario, curp_destinatario, sexo_masculino);
                                            Console.WriteLine("Proceso de registo terminado");
                                            Console.Write("Presione la tecla <Enter> para continuar...");
                                            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                                            Console.Clear();
                                            
                                            //Llamada a método
                                            Console.WriteLine("\t\t*** Despliegue de aviso ***\n");
                                            InfraccionHacienda.MostrarAviso();
                                            Console.Write("\n\t*** Firma de recibido ***\n");
                                            firma_electronica = CapturaString("una palabra o frase");
                                            Console.WriteLine("\n");
                                            InfraccionHacienda.FirmaRecibido(firma_electronica);
                                            Console.WriteLine("Mensaje enviado correctamente");
                                            Console.Write("Presione la tecla <Enter> para continuar...");
                                            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                                            Console.Clear();
                                        }
                                        break;
                                    case 3: // Salir del programa
                                        {
                                            Console.Clear();
                                            Console.Write("Presione la tecla <Esc> para cerrar el programa...");
                                            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
                                            aux_menu_tipo_avisos_gob = false;
                                            aux_ejecucion = false;
                                        }
                                        break;
                                    default: // Caso dato incorrecto 
                                        {
                                            Console.WriteLine("La opción ingresada no ha sido válida.\nAsegúrese de escribir el número correcto");
                                            Console.Write("Presione la tecla <Enter> para continuar...");
                                            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                                            Console.Clear();
                                        }
                                        break;
                                }
                            }
                            while (aux_menu_tipo_avisos_gob); // Condicion para controlar menú de avisos gubernamentales
                        }
                        break;
                    case 2: // Aviso Escolar
                        {
                            do // Do while para controlar menú de Avisos Escolar
                            {   
                                //Despliegue de menú de Aviso Escolar 
                                Console.WriteLine("\t\t*** Aviso Escolar ***");
                                Console.WriteLine("\n¿Qué tipo de aviso deseas enviar?");
                                Console.WriteLine("\n1 - Aviso de Servicios Escolares\n2 - Aviso de Departamento de Sistemas y Computación\n3 - Salir del programa");

                                //Captura de datos
                                aux_tipo_aviso_escolar = CapturaShort("el número del tipo de aviso deseado");
                                Console.WriteLine("Opción registrada");
                                Console.Write("Presione la tecla <Enter> para continuar...");
                                while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                                Console.Clear();
                                switch (aux_tipo_aviso_escolar) // Switch case para controlar las opciones
                                {
                                    case 1: //Servicios escolares
                                        {
                                            //Captura de datos
                                            Console.WriteLine("*** Aviso Servicios Escolares ***");
                                            Console.WriteLine("\nCapture los datos que se le pidan");
                                            mensaje = CapturaString("el mensaje personalizado que se enviará(dejar en blanco en caso de no querer enviarlo)");
                                            fecha = CapturaString("la fecha en la que se enviará");
                                            nombre_alumno = CapturaString("el nombre del alumno");
                                            numero_control_alumno = CapturaInt("el número de control del alumno");
                                            Console.WriteLine("¿Qué sexo tiene el alumno? H | M" +
                                                              "\nIngrese en MAYÚSCULAS la letra de la opción deseada" +
                                                              "\nGlosario(H = Hombre, M = Mujer)");
                                            aux_sexo = CapturaChar("su respuesta aquí");
                                            switch (aux_sexo)
                                            {
                                                case 'H':
                                                    {
                                                        alumno_es_hombre = true;
                                                    }
                                                    break;
                                                case 'M':
                                                    {
                                                        alumno_es_hombre = false;
                                                    }
                                                    break;
                                                default:
                                                    {
                                                        Console.WriteLine("La opción ingresada no es válida. El proceso se reiniciará");
                                                        Console.Write("Presione la tecla <Enter> para continuar...");
                                                        while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                                                        Console.Clear();
                                                    }
                                                    break;
                                            }
                                            Console.WriteLine("Datos registrados");
                                            Console.Write("Presione la tecla <Enter> para continuar...");
                                            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                                            Console.Clear();

                                            do // Do while para controlar menú Servicios Escolares
                                            {
                                                //Despliegue del menú Servicios Escolares
                                                Console.WriteLine("\t*** Aviso Escolar ***");
                                                Console.WriteLine("\n¿Qué acción desea realizar?");
                                                Console.WriteLine("1 - Aviso personalizado\n2 - Aviso cancelación de clases\n3 - Aviso Entrega de credenciales\n4 - Salir del programa\n");

                                                //Captura de datos
                                                aux_tipo_aviso_servicios_escolares = CapturaShort("el número de la acción deseada");
                                                Console.WriteLine("Opción registrada");
                                                Console.Write("\tPresione la tecla <Enter> para continuar...");
                                                while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                                                Console.Clear();

                                                //Creación del objeto
                                                clsAvisosServiciosEscolares AvisoEscolar = new clsAvisosServiciosEscolares(mensaje, fecha, nombre_alumno, numero_control_alumno, alumno_es_hombre);
                                                switch (aux_tipo_aviso_servicios_escolares) // Switch case para controlar las opciones
                                                {
                                                    case 1: // Aviso personalizado
                                                        {
                                                            //Llamada a método
                                                            Console.WriteLine("\t\t*** Despliegue de aviso ***\n");
                                                            AvisoEscolar.MostrarAviso();
                                                            Console.WriteLine("\nMensaje enviado correctamente");
                                                            Console.Write("Presione la tecla <Enter> para continuar...");
                                                            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                                                            Console.Clear();
                                                        }
                                                        break;
                                                    case 2: // Aviso cancelación de clases
                                                        {

                                                            Console.WriteLine("\t\t*** Despliegue de aviso de cancelación de clases ***");
                                                            //Captura de dato
                                                            fecha_cancelacion = CapturaString("la fecha de cancelación de clases");
                                                            Console.WriteLine("Dato capturado");
                                                            Console.Write("Presione la tecla <Enter> para continuar...");
                                                            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                                                            Console.Clear();

                                                            //LLamada a método
                                                            Console.WriteLine("\t\t*** Despliegue de aviso de cancelación de clases ***\n");
                                                            AvisoEscolar.CancelarClases(fecha_cancelacion);
                                                            Console.WriteLine("\nMensaje enviado correctamente");
                                                            Console.Write("Presione la tecla <Enter> para continuar...");
                                                            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                                                            Console.Clear();
                                                        }
                                                        break;
                                                    case 3: // Aviso entrega de credenciales
                                                        {
                                                            //LLamada a método
                                                            Console.WriteLine("\t\t*** Despliegue de aviso de entrega de credenciales ***\n");
                                                            AvisoEscolar.EntregaCredenciales();
                                                            Console.WriteLine("\nMensaje enviado correctamente");
                                                            Console.Write("Presione la tecla <Enter> para continuar...");
                                                            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                                                            Console.Clear();
                                                        }
                                                        break;
                                                    case 4: //Salir del programa
                                                        {
                                                            Console.Write("\tPresione la tecla <Esc> para cerrar el programa...");
                                                            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
                                                            aux_menu_servicios_escolares = false;
                                                            aux_menu_tipo_avisos_esc = false;
                                                            aux_ejecucion = false;
                                                        }
                                                        break;
                                                    default: // Caso dato incorrecto
                                                        {
                                                            Console.WriteLine("La opción ingresada no es válida. El proceso se reiniciará");
                                                            Console.Write("Presione la tecla <Enter> para continuar...");
                                                            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                                                            Console.Clear();
                                                        }
                                                        break;
                                                }
                                            }
                                            while (aux_menu_servicios_escolares); // Condicion para menú Servicios Escolares
                                        }
                                        break;
                                    case 2: // Departamento sistemas
                                        {
                                            //Captura de datos
                                            Console.WriteLine("*** Aviso Departamento Sistemas ***");
                                            Console.WriteLine("\nCapture los datos que se le pidan");
                                            mensaje = CapturaString("el mensaje personalizado que se enviará(dejar en blanco en caso de no querer enviarlo)");
                                            fecha = CapturaString("la fecha en la que se enviará");
                                            nombre_alumno = CapturaString("el nombre del alumno");
                                            numero_control_alumno = CapturaInt("el número de control del alumno");
                                            Console.WriteLine("¿Qué sexo tiene el alumno? H | M" +
                                                              "\nIngrese en MAYÚSCULAS la letra de la opción deseada" +
                                                              "\nGlosario(H = Hombre, M = Mujer)");
                                            aux_sexo = CapturaChar("su respuesta aquí");
                                            switch (aux_sexo)
                                            {
                                                case 'H':
                                                    {
                                                        alumno_es_hombre = true;
                                                    }
                                                    break;
                                                case 'M':
                                                    {
                                                        alumno_es_hombre = false;
                                                    }
                                                    break;
                                                default:
                                                    {
                                                        Console.WriteLine("La opción ingresada no es válida. El proceso se reiniciará");
                                                        Console.Write("Presione la tecla <Enter> para continuar...");
                                                        while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                                                        Console.Clear();
                                                    }
                                                    break;
                                            }
                                            Console.WriteLine("Datos registrados");
                                            Console.Write("Presione la tecla <Enter> para continuar...");
                                            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                                            Console.Clear();

                                            do //Do while para controlar menú Sistemas
                                            {
                                                //Despliegue del menú Sistemas
                                                Console.WriteLine("\t*** Departamento Sistemas ***");
                                                Console.WriteLine("\n¿Qué acción desea realizar?");
                                                Console.WriteLine("1 - Aviso personalizado\n2 - Aviso cancelación de clases\n3 - Aviso InnovaTec\n4 - Salir del programa\n");

                                                //Captura de datos
                                                aux_tipo_aviso_servicios_escolares = CapturaShort("el número de la acción deseada");
                                                Console.WriteLine("Opción registrada");
                                                Console.Write("\tPresione la tecla <Enter> para continuar...");
                                                while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                                                Console.Clear();

                                                //Creación del objeto
                                                clsAvisosDepartamentoSistemas AvisoSistemas = new clsAvisosDepartamentoSistemas(mensaje, fecha, nombre_alumno, numero_control_alumno, alumno_es_hombre);
                                                switch (aux_tipo_aviso_servicios_escolares) // Switch case para controlar las opciones
                                                {
                                                    case 1: // Aviso personalizado
                                                        {
                                                            //Llamada a método
                                                            Console.WriteLine("\t\t*** Despliegue de aviso ***\n");
                                                            AvisoSistemas.MostrarAviso();
                                                            Console.WriteLine("\nMensaje enviado correctamente");
                                                            Console.Write("Presione la tecla <Enter> para continuar...");
                                                            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                                                            Console.Clear();
                                                        }
                                                        break;
                                                    case 2: // Aviso cancelación de clases
                                                        {

                                                            Console.WriteLine("\t\t*** Despliegue de aviso de cancelación de clases ***");
                                                            //Captura de dato
                                                            fecha_cancelacion = CapturaString("la fecha de cancelación de clases");
                                                            Console.WriteLine("Dato capturado");
                                                            Console.Write("Presione la tecla <Enter> para continuar...");
                                                            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                                                            Console.Clear();

                                                            //LLamada a método
                                                            Console.WriteLine("\t\t*** Despliegue de aviso de cancelación de clases ***\n");
                                                            AvisoSistemas.CancelarClases(fecha_cancelacion);
                                                            Console.WriteLine("\nMensaje enviado correctamente");
                                                            Console.Write("Presione la tecla <Enter> para continuar...");
                                                            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                                                            Console.Clear();
                                                        }
                                                        break;
                                                    case 3: // Aviso InnovaTec
                                                        {
                                                            //Captura de dato
                                                            fecha_innovatec = CapturaString("la fecha del InnovaTec");
                                                            Console.WriteLine("Dato capturado");
                                                            Console.Write("Presione la tecla <Enter> para continuar...");
                                                            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                                                            Console.Clear();

                                                            //LLamada a método
                                                            Console.WriteLine("\t\t*** Despliegue de aviso de InnovaTec ***\n");
                                                            AvisoSistemas.InnovaTec(fecha_innovatec);
                                                            Console.WriteLine("\nMensaje enviado correctamente");
                                                            Console.Write("Presione la tecla <Enter> para continuar...");
                                                            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                                                            Console.Clear();
                                                        }
                                                        break;
                                                    case 4: //Salir del programa
                                                        {
                                                            Console.Write("\tPresione la tecla <Esc> para cerrar el programa...");
                                                            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
                                                            aux_menu_sistemas = false;
                                                            aux_menu_tipo_avisos_esc = false;
                                                            aux_ejecucion = false;
                                                        }
                                                        break;
                                                    default: // Caso dato incorrecto
                                                        {
                                                            Console.WriteLine("La opción ingresada no es válida. El proceso se reiniciará");
                                                            Console.Write("Presione la tecla <Enter> para continuar...");
                                                            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                                                            Console.Clear();
                                                        }
                                                        break;
                                                }
                                            }
                                            while (aux_menu_sistemas); // Condición para menú sistemas
                                        }
                                        break;
                                    case 3: // Salir del programa
                                        {
                                            // Mensaje final
                                            Console.Write("\tPresione la tecla <Esc> para cerrar el programa...");
                                            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
                                            aux_menu_tipo_avisos_esc = false;
                                            aux_ejecucion = false;
                                        }
                                        break;
                                    default: // Caso dato incorrecto
                                        {
                                            Console.WriteLine("La opción ingresada no ha sido válida.\nAsegúrese de escribir el número correcto");
                                            Console.Write("\tPresione la tecla <Enter> para continuar...");
                                            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                                            Console.Clear();
                                        }
                                        break;
                                }
                            }
                            while (aux_menu_tipo_avisos_esc);
                        }
                        break;
                    case 3: // Salir del programa
                        {
                            aux_ejecucion = false;
                            Console.Clear();
                            Console.Write("\tPresione la tecla <Esc> para cerrar el programa...");
                            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
                        }
                        break;
                    default: // Caso dato incorrecto
                        {
                            Console.WriteLine("La opción ingresada no ha sido válida.\nAsegúrese de escribir el número correcto");
                            Console.Write("\tPresione la tecla <Enter> para continuar...");
                            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                            Console.Clear();
                        }
                        break;
                }
            }
            while (aux_ejecucion); // Condición para controlar menú general y ejecución del programa
        }
    }
}