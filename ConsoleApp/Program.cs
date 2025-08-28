// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
public class Salones
{

    int CantidadSalon;
    String? NombreSalon;
    String? DisponibilidadSalon;
    TimeOnly HorarioSalon;
    public List<SucursalSalones>? SucursalSalones;

}
public class TipoSalones
{
    int codSalon;
    String? TipoSalon;
}
public class SucursalSalones
{
    String? NombreSucursal;
    Char? DireccionSucursal;
}
