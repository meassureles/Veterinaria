using System;

namespace PracticaVeterinaria.App.Dominio
{
    public class Visita
    {
        public int Id { get; set; }
        public float Peso { get; set; }
        public float Temperatura { get; set; }
        public int FR { get; set; }
        public int FC { get; set; }
        public string EstadoAnimo { get; set; }
        public DateOnly fechaVisita { get; set; }
        public string Recomendacion { get; set; }
        public Diagnostico Diagnostico { get; set; }
        public Formula Formula { get; set; }
        public Veterinario Veterinario { get; set; }

    }
}