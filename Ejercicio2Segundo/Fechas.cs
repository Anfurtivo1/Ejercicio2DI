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


                diferenciaFecha = (fecha - fechaDias);
                cantidadDias = diferenciaFecha.TotalDays;
                Console.WriteLine(cantidadDias);

                Console.WriteLine("****COMPARAR FECHAS*****");

                Console.WriteLine("Indica una fecha");
                fechaAComparar1 = Console.ReadLine();
                Console.WriteLine("Indica otra fecha");
                fechaAComparar2 = Console.ReadLine();

                compararFecha1 = Convert.ToDateTime(fechaAComparar1);
                compararFecha2 = Convert.ToDateTime(fechaAComparar2);
                cantidadComparar = compararFecha1.CompareTo(compararFecha2);
                Console.WriteLine(cantidadComparar + " dias hay de diferencia entre ambas fechas");

            }
            catch (Exception e)
            {
                Console.WriteLine("Se ha producido un error en " + e);
            }
        }

    }
}
