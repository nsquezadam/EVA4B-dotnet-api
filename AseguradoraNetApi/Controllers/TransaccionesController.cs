using Microsoft.AspNetCore.Mvc;
using AseguradoraNetApi.Models;

namespace AseguradoraNetApi.Controllers;

[ApiController]
[Route("api/transacciones")]
public class TransaccionesController : ControllerBase
{
    private static readonly List<Transaccion> transacciones = new();
    private static int id = 1;

    [HttpPost]
    public IActionResult Registrar([FromBody] Transaccion tx)
    {
        tx.Id = id++;
        tx.FechaUtc = DateTime.UtcNow;
        tx.Estado = "OK";
        transacciones.Add(tx);
        return Ok(tx);
    }

    [HttpGet]
    public IActionResult Listar() => Ok(transacciones);
}
