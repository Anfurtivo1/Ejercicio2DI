﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio2Segundo
{
    class YateLujo : Barco
    {
        int potencia;
        int numeroCamarotes;

        public YateLujo(int potencia, int numeroCamarotes)
        {
            this.Potencia = potencia;
            this.NumeroCamarotes = numeroCamarotes;
        }

        public int Potencia { get => potencia; set => potencia = value; }
        public int NumeroCamarotes { get => numeroCamarotes; set => numeroCamarotes = value; }

        public override double CalcularAlquiler(Barco barco, Cliente cliente)
        {
            //Se calcula el numero de dias de ocupacion(fechaInicio y fechaFinal incluidas) por un modulo funcion (que sale de multiplicar
            //los metros de eslora por 10) y por 12. Si son especiales:
            //para los veleros, se suma el numero de mastiles
            //para las embarcaciones deportivas a motor, la potencia
            //para los yates se suma la potencia y el numero de camarotes
            DateTime fechaInicio;
            DateTime fechaFinal;
            double eslora;
            fechaInicio = cliente.FechaInicio;
            fechaFinal = cliente.FechaFinal;
            eslora = barco.Eslora;
            double fechaTotal;
            TimeSpan fechas;
            double total;

            fechas = fechaFinal.Subtract(fechaInicio);
            fechaTotal = fechas.Days;

            total = fechaTotal * eslora * 12 + this.Potencia+this.NumeroCamarotes;
            return total;
        }
    }
}
