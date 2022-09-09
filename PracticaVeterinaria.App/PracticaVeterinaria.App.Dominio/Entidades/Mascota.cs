using System;

namespace PracticaVeterinaria.App.Dominio
{
    public class Mascota
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Color { get; set; }
        public string Especie { get; set; }
        public int Raza { get; set; }       
        public Propietario Propietario { get; set; }
        public Veterinario Veteriario { get; set; }
    }
}