using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Ejercicio2Segundo
{
    class CrearBarco
    {
        private Velero velero;
        private DeportivoMotor deportivoMotor;
        private YateLujo yateLujo;


        public Barco crearBarco(Cliente cliente)
        {
            Velero velero;
            int numeroMastiles=0;
            DeportivoMotor deportivoMotor;
            int potencia=0;
            YateLujo yateLujo;
            int numeroCamarotes = 0;
            String opcion;
            Console.WriteLine("Indica que tipo de barco quieres");

            opcion=Console.ReadLine();
            opcion=opcion.ToLower();
            if (opcion.Equals("velero"))
            {
                Console.WriteLine("Indica la cantidad de mastiles");
                numeroMastiles = int.Parse(Console.ReadLine());
                velero = new Velero(numeroMastiles);
                velero.Matricula="123-A";
                velero.Eslora = 1;
                velero.AñosFabricacion = 1990;
                return velero;
            }
            if (opcion.Equals("deportivo a motor"))
            {
                Console.WriteLine("Indica la potencia");
                potencia = int.Parse(Console.ReadLine());
                deportivoMotor = new DeportivoMotor(potencia);
                deportivoMotor.Matricula = "123-B";
                deportivoMotor.Eslora = 2;
                deportivoMotor.AñosFabricacion = 1991;
                return deportivoMotor;
            }
            if (opcion.Equals("yate de lujo"))
            {
                Console.WriteLine("Indica la potencia");
                potencia = int.Parse(Console.ReadLine());
                Console.WriteLine("Indica el numero de camarotes");
                numeroCamarotes = int.Parse(Console.ReadLine());
                yateLujo = new YateLujo(potencia,numeroCamarotes);
                yateLujo.Matricula = "123-C";
                yateLujo.Eslora = 3;
                yateLujo.AñosFabricacion = 1992;
                return yateLujo;
            }
            else
            {
                Console.WriteLine("No es una opcion valida");
                return null;
            }
            
        }
        public double calculoAlquiler(Barco barco,Cliente cliente)
        {
            double precio;
            try
            {
                if (barco.GetType() == typeof(Velero))
                {
                    precio = barco.CalcularAlquiler(barco, cliente);
                    return precio;
                }

                if (barco.GetType() == typeof(DeportivoMotor))
                {
                    precio = barco.CalcularAlquiler(barco, cliente);
                    return precio;
                }

                if (barco.GetType() == typeof(YateLujo))
                {
                    precio = barco.CalcularAlquiler(barco, cliente);
                    return precio;
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("Error en "+e);
            }


            return 0;
        }

    }
}
