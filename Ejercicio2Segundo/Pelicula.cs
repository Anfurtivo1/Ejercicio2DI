using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio2Segundo
{
    class Pelicula
    {
        String titulo;
        String director;
        int listadoActores;

        public string Titulo { get => titulo; set => titulo = value; }
        public string Director { get => director; set => director = value; }
        public int ListadoActores { get => listadoActores; set => listadoActores = value; }

        public Pelicula(String titulo,String director,int listadoActores)
        {
            this.Titulo = titulo;
            this.Director = director;
            this.ListadoActores = listadoActores;
        }

        public Pelicula()
        {

        }



        public String mostrarInfo()
        {
            return "Titulo: " + titulo+" Director:"+director+" listado de actores: "+listadoActores;

        }

    }
}
