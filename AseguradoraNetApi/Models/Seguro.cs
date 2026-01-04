namespace AseguradoraNetApi.Models;

public class Seguro
{
    public int Id { get; set; }
    public int ClienteId { get; set; }
    public int ProductoId { get; set; }
    public decimal Prima { get; set; }
    public string Estado { get; set; } = "ACTIVO";
}
