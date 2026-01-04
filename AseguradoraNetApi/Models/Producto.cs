namespace AseguradoraNetApi.Models;

public class Producto
{
    public int Id { get; set; }
    public string Nombre { get; set; } = "";
    public string TipoPagoPrima { get; set; } = "AUTOMATICO"; // AUTOMATICO|CHEQUE|EFECTIVO
}
