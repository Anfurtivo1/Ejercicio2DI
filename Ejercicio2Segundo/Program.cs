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

                        ArrayList peliculas = new ArrayList();
                        int opcionP;
                        Pelicula pelicula;
                        String titulo;
                        String director;
                        int listadoActores;
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
                                    Console.WriteLine("\tIndica el titulo");
                                    titulo = Console.ReadLine();
                                    Console.WriteLine("\tIndica el director");
                                    director = Console.ReadLine();
                                    Console.WriteLine("\tIndica la cantidad de actores");
                                    listadoActores = int.Parse(Console.ReadLine());

                                    pelicula = new Pelicula(titulo,director,listadoActores);
                                    peliculas.Add(pelicula);

                                    break;

                                case 2:
                                    Pelicula pelicula1;
                                    Console.WriteLine("Estas son todas las peliculas que se han añadido");
                                    for (int i = 0; i < peliculas.Count; i++)
                                    {
                                        pelicula1 = (Pelicula)peliculas[i];
                                        Console.WriteLine(pelicula1.mostrarInfo());
                                    }
                                    
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;

                                case 3:
                                    Pelicula pelicula2;
                                    String nombrePeli="";
                                    String tituloN="";
                                    String directorN="";
                                    int listadoAN=1;
                                    Console.WriteLine("Estas son todas las peliculas que se han añadido");
                                    for (int i = 0; i < peliculas.Count; i++)
                                    {
                                        pelicula2 = (Pelicula)peliculas[i];
                                        if (pelicula2.Titulo.Equals(nombrePeli))
                                        {
                                            pelicula2.Director = directorN;
                                            pelicula2.Titulo = tituloN;
                                            pelicula2.ListadoActores = listadoAN;
                                        }
                                    }

                                    Console.ReadKey();
                                    Console.Clear();
                                    break;

                                case 4:

                                    Console.ReadKey();
                                    Console.Clear();
                                    break;

                                case 5:
                                    Console.WriteLine("\tSe acabaron las peliculas");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                default:
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                            }

                        } while (opcionP!=5);

                        

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
