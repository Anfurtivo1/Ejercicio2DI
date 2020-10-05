using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio2Segundo
{
     public class Cliente
    {
        private String nombreCliente;
        private String DNICliente;
        private DateTime fechaInicio;
        private DateTime fechaFinal;
        private int posicionAmarre;
        private int barcoOcupando;

        public Cliente()
        {

        }

        public Cliente(string nombreCliente, string dNICliente, DateTime fechaInicio, DateTime fechaFinal, int posicionAmarre, int barcoOcupando)
        {
            this.NombreCliente = nombreCliente;
            DNICliente1 = dNICliente;
            this.FechaInicio = fechaInicio;
            this.FechaFinal = fechaFinal;
            this.PosicionAmarre = posicionAmarre;
            this.BarcoOcupando = barcoOcupando;
        }

        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string DNICliente1 { get => DNICliente; set => DNICliente = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFinal { get => fechaFinal; set => fechaFinal = value; }
        public int PosicionAmarre { get => posicionAmarre; set => posicionAmarre = value; }
        public int BarcoOcupando { get => barcoOcupando; set => barcoOcupando = value; }

        

    }
}
