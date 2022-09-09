using System;

namespace PracticaVeterinaria.App.Dominio
{
    public class Formula

    {
        public int Id {get; set;}
        public int Cantidad {get; set;}
        public string Descripcion {get; set;}
        public float Dosis {get; set;}
        public Mascota Mascota {get; set;}

    }
}