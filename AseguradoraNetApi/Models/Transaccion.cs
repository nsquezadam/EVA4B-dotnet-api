namespace AseguradoraNetApi.Models;

public class Transaccion
{
    public int Id { get; set; }
    public string Tipo { get; set; } = "EMISION";
    public int ClienteId { get; set; }
    public int ProductoId { get; set; }
    public string Estado { get; set; } = "OK";
    public DateTime FechaUtc { get; set; } = DateTime.UtcNow;
}
