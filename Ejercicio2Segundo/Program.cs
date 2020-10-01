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

                        ArrayList myAL = new ArrayList();
                        myAL.Add("Hello");
                        myAL.Add("World");
                        myAL.Add("!");
                        String prueba;

                        // Displays the properties and values of the ArrayList.
                        Console.WriteLine("myAL");
                        Console.WriteLine("    Count:    {0}", myAL.Count);
                        Console.WriteLine("    Capacity: {0}", myAL.Capacity);
                        Console.Write("    Values:");
                        for (int i = 0; i < myAL.Count; i++)
                        {
                            Console.WriteLine(myAL[i]);
                        }
                        if (true)
                        {

                        }

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
