// Implementar la firma de los metodos CRUD

using PracticaVeterinaria.App.Persistencia
{
    public interface IRepositorioPropietario
    {
    Propietario AddPropietario(Propietario propietario);
    Propietario UpdatePropietario(IRepositorioPropietario propietario);

    void DeletePropietario(int idPropietario);

    //IEnumerable - me permite retornar una lista de objetos

    IEnumerable<Propietario> GetAllPropietarios();
    Propietario GetPropietario(int idPropietario);
    }
}