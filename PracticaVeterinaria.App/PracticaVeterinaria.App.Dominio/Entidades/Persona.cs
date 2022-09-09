namespace PracticaVeterinaria.App.Dominio
{
    public class Persona
    {
        public int Id { get; set; }
        public int DNI { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }       
    }
}