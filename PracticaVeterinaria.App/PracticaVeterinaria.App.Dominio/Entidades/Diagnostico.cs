using System;

namespace PracticaVeterinaria.App.Dominio
{
    public class Diagnostico

    {
        public int Id {get; set;}
        public string Descripcion {get; set;}
        public Mascota Mascota {get; set;}

    }
}