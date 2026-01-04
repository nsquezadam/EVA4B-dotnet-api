using Microsoft.AspNetCore.Mvc;
using AseguradoraNetApi.Models;

namespace AseguradoraNetApi.Controllers;

[ApiController]
[Route("api/productos")]
public class ProductosController : ControllerBase
{
    private static readonly List<Producto> productos = new();
    private static int id = 1;

    [HttpPost]
    public IActionResult Crear([FromBody] Producto producto)
    {
        producto.Id = id++;
        if (string.IsNullOrWhiteSpace(producto.TipoPagoPrima))
            producto.TipoPagoPrima = "AUTOMATICO";

        productos.Add(producto);
        return Ok(producto);
    }

    // Asignar tipo de pago de prima (AUTOMATICO/CHEQUE/EFECTIVO)
    [HttpPost("{id}/pago/{tipoPago}")]
    public IActionResult AsignarPago(int id, string tipoPago)
    {
        var p = productos.FirstOrDefault(x => x.Id == id);
        if (p == null) return NotFound();

        var t = (tipoPago ?? "").ToUpperInvariant();
        if (t != "AUTOMATICO" && t != "CHEQUE" && t != "EFECTIVO")
            t = "AUTOMATICO";

        p.TipoPagoPrima = t;
        return Ok(p);
    }

    [HttpGet]
    public IActionResult Listar() => Ok(productos);
}
