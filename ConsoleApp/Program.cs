// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Salones salon = new Salones();
salon.CantidadSalon = 5;
salon.NombreSalon = "Salon de Bailes tradicionales";
salon.HorarioSalon = DateTime.Now;
salon.TipoSalones = new TipoSalones() { codSalon = 123, TipoSalon = "Salon de Salsa" };
salon.SucursalSalones = new List<SucursalSalones>();
salon.SucursalSalones.Add(new SucursalSalones() { NombreSucursal = "Sucursal el Tesoro" , DireccionSucursal="Carrera 25A No. 1A Sur – 45"});
salon.SucursalSalones.Add(new SucursalSalones() { NombreSucursal = "Sucursal Laureles", DireccionSucursal = "Avenida 80" });
salon.disponibilidadSalones = true;
Console.WriteLine(salon.NombreSalon);
Console.WriteLine(salon.TipoSalones.codSalon);
foreach (var elemento in salon.SucursalSalones)
{
    Console.WriteLine(elemento.NombreSucursal);
}

public class Salones
{

    public int CantidadSalon;
    public String? NombreSalon;
    public DateTime HorarioSalon;
    public List<SucursalSalones>? SucursalSalones;
    public TipoSalones? TipoSalones;
    public bool? disponibilidadSalones;


}
public class TipoSalones
{
    public int codSalon;
    public String? TipoSalon;
    public List<Salones>? Salones;
}
public class SucursalSalones
{
    public String? NombreSucursal;
    public String? DireccionSucursal;
}
public class DisponibilidadSalones {
    public bool Disponible;
}
