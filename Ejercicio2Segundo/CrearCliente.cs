using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio2Segundo
{
    class CrearCliente
    {
        private Cliente cliente = new Cliente();

        public Cliente crearcliente()
        {
            DateTime fechaInicio;
            DateTime fechaFinal;
            String fechaI;
            String fechaF;
            cliente.NombreCliente = "Cliente1";
            cliente.DNICliente1 = "123-A";
            cliente.PosicionAmarre = 1;
            cliente.BarcoOcupando = 123;
            Console.WriteLine("Indica la fecha inicial");
            fechaI=Console.ReadLine();
            fechaInicio = Convert.ToDateTime(fechaI);
            Console.WriteLine("Indica la fecha final");
            fechaF = Console.ReadLine();
            fechaFinal = Convert.ToDateTime(fechaF);

            cliente.FechaInicio=fechaInicio;
            cliente.FechaFinal = fechaFinal;

            return cliente;
        }

    }
}
