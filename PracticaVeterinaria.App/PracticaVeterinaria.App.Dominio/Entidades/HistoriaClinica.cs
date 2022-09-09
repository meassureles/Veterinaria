using System;

namespace PracticaVeterinaria.App.Dominio
{
    public class Historia_Clinica
    {
        public int Id {get; set;}
        public DateOnly FechaApertura {get; set;}
        public Visita Visita {get; set;}
    }
}