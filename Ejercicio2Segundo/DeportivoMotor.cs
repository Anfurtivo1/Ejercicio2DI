using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio2Segundo
{
    class DeportivoMotor : Barco
    {
        int potencia;

        public DeportivoMotor(int potencia)
        {
            this.Potencia = potencia;
        }

        public int Potencia { get => potencia; set => potencia = value; }

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
            //Para probar, la fecha entre las dos será 30
            double fechaTotal = 30;
            double total;

            total = fechaTotal * eslora * 12 + this.Potencia;
            return total;
        }
    }
}
