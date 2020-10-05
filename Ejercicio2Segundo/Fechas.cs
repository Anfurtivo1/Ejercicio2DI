using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio2Segundo
{
    class Fechas
    {

        public void calculoFechas()
        {
            DateTime fecha = new DateTime();
            DateTime fechaDias = new DateTime();
            String fechaIntroducir;
            String fecha2;
            String fechaResta1;
            String fechaResta2;
            DateTime fechaResta3;
            DateTime fechaResta4;
            int numeroDias;
            TimeSpan diferenciaFecha;
            double cantidadDias;
            DateTime compararFecha1;
            DateTime compararFecha2;
            String fechaAComparar1;
            String fechaAComparar2;
            int cantidadComparar;

            Console.WriteLine("****AÑADIR DIAS A FECHA*****");

            Console.WriteLine("Introduce una fecha");
            try
            {
                fechaIntroducir = Console.ReadLine();
                fecha = Convert.ToDateTime(fechaIntroducir);
                fecha2 = fecha.ToLongDateString();
                Console.WriteLine(fecha2);

                Console.WriteLine("Indica cuantos dias quieres añadir");
                numeroDias = int.Parse(Console.ReadLine());
                fechaDias = fecha.AddDays(numeroDias);
                Console.WriteLine(fechaDias.ToShortDateString());

                Console.WriteLine("****RESTAR FECHAS*****");

                Console.WriteLine("Indica una fecha");
                fechaResta1 = Console.ReadLine();
                Console.WriteLine("Indica otra fecha");
                fechaResta2 = Console.ReadLine();

                fechaResta3 = Convert.ToDateTime(fechaResta1);
                fechaResta4 = Convert.ToDateTime(fechaResta2);

                diferenciaFecha = fechaResta3.Subtract(fechaResta4);
                Console.WriteLine("Hay una diferencia de "+diferenciaFecha+" dias");

                Console.WriteLine("****COMPARAR FECHAS*****");

                Console.WriteLine("Indica una fecha");
                fechaAComparar1 = Console.ReadLine();
                Console.WriteLine("Indica otra fecha");
                fechaAComparar2 = Console.ReadLine();

                compararFecha1 = Convert.ToDateTime(fechaAComparar1);
                compararFecha2 = Convert.ToDateTime(fechaAComparar2);
                cantidadComparar = compararFecha1.CompareTo(compararFecha2);
                if (cantidadComparar==1)
                {
                    Console.WriteLine("La fecha "+fechaAComparar1+" es mayor que la fecha "+fechaAComparar2);
                }

                if (cantidadComparar == 0)
                {
                    Console.WriteLine("La fecha " + fechaAComparar1 + " es igual que la fecha " + fechaAComparar2);
                }

                if (cantidadComparar == -1)
                {
                    Console.WriteLine("La fecha " + fechaAComparar1 + " es menor que la fecha " + fechaAComparar2);
                }
               

            }
            catch (Exception e)
            {
                Console.WriteLine("Se ha producido un error en " + e);
            }
        }

    }
}
