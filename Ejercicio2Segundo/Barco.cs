using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio2Segundo
{
    public abstract class Barco
    {
        private String matricula;
        private double eslora;
        private int añosFabricacion;


        public string Matricula { get => matricula; set => matricula = value; }
        public double Eslora { get => eslora; set => eslora = value; }
        public int AñosFabricacion { get => añosFabricacion; set => añosFabricacion = value; }

        public abstract double CalcularAlquiler(Barco barco, Cliente cliente);
        //Se calcula el numero de dias de ocupacion(fechaInicio y fechaFinal incluidas) por un modulo funcion (que sale de multiplicar
        //los metros de eslora por 10) y por 12. Si son especiales:
        //para los veleros, se suma el numero de mastiles
        //para las embarcaciones deportivas a motor, la potencia
        //para los yates se suma la potencia y el numero de camarotes

    }

}
