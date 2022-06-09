using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ArchivosBinarios
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaracion de variables auxiliares
            string Arch = null;
            int opcion;

            //Creacion de objeto
            ArchivoBinarioEmpleados A1 = new ArchivoBinarioEmpleados();

            //Menu de Opciones
            do
            {
                Console.Clear();
                Console.WriteLine("\n*** ARCHIVO BINARIO EMPLEADOS***");
                Console.WriteLine("1.- Creacion de un Archivo");
                Console.WriteLine("2.- Lectura de un Archivo");
                Console.WriteLine("3.- Salida del Programa");
                opcion = Int16.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        //bloque de escritura
                        try
                        {
                            //captura nombre archivo
                            Console.Write("\nAlimenta el Nombre del Archivo a Crear: ");
                            Arch = Console.ReadLine();

                            //verfica si existe el archivo
                            char resp = 's';
                            if (File.Exists(Arch))
                            {
                                Console.Write("El Archivo Existe! !, Deseas" +
                                    " Sobreescribirlo (s/n) ? ");
                                resp = Char.Parse(Console.ReadLine());
                            }
                            if ((resp == 's') || (resp == 'S'))
                            {
                                A1.CrearArchivo(Arch);
                            }
                        }
                        catch (IOException e)
                        {
                            Console.WriteLine("\nError : " + e.Message);
                            Console.WriteLine("\nRuta : " + e.StackTrace);
                        }
                        break;

                    case 2:
                        //bloque de lectura
                        try
                        {
                            //captura nombre archivo
                            Console.Write("\nAlimenta el Nombre del Archivo que" +
                                " deseas Leer: ");
                            Arch = Console.ReadLine();
                            A1.MostrarArchivo(Arch);
                        }
                        catch (IOException e)
                        {
                            Console.WriteLine("\nError : " + e.Message);
                            Console.WriteLine("\nRuta : " + e.StackTrace);
                        }
                        break;

                    case 3:
                        Console.Write("\nPresione <Enter> para Salir del Programa.");
                        Console.ReadKey();
                        break;

                    default:
                        Console.Write("\nEsa Opcion No Existe ! !, " +
                            "Presione <Enter> para Continuar . . .");
                        Console.ReadKey();
                        break;
                }
            } while (opcion != 3);
        }
    }
}
