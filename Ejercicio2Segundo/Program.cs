using System;
using System.Collections;
namespace Ejercicio2Segundo
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.WriteLine("\tElige una opcion");
                Console.WriteLine("\t1- Ejercicio Manejar Fechas");
                Console.WriteLine("\t2- Ejercicio Clase Pelicula");
                Console.WriteLine("\t3- Ejercicio ALquiler Puerto");
                Console.WriteLine("\t4- Salir");

                opcion = int.Parse(Console.ReadLine());
                
                switch (opcion)
                {
                    case 1:
                        Fechas fecha = new Fechas();
                        fecha.calculoFechas();
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:

                        ArrayList peliculas;
                        int opcionP;
                        do
                        {
                            Console.WriteLine("\tElige una opcion");
                            Console.WriteLine("\t1- Insertar peliculas");
                            Console.WriteLine("\t2- Ver listado peliculas");
                            Console.WriteLine("\t3- Modificar alguna pelicula de las insertadas");
                            Console.WriteLine("\t4- Eliminar alguna pelicula de las insertadas");
                            Console.WriteLine("\t5- Salir");

                            opcionP = int.Parse(Console.ReadLine());

                            switch (opcionP)
                            {
                                case 1:

                                break;

                                case 2:

                                    break;

                                case 3:

                                    break;

                                case 4:

                                    break;

                                case 5:

                                    break;
                                default:
                                    break;
                            }

                        } while (true);

                        

                        /*
                        Console.WriteLine("    Count:    {0}", myAL.Count);
                        Console.WriteLine("    Capacity: {0}", myAL.Capacity);
                        myAL.Remove(prueba);
                        for (int i = 0; i < myAL.Count; i++)
                        {
                            Console.WriteLine(myAL[i]);
                        }
                        */

                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3:
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 4:
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (opcion != 4);

        }
    }
}
