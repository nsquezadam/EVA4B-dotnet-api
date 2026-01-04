using Microsoft.AspNetCore.Mvc;
using AseguradoraNetApi.Models;

namespace AseguradoraNetApi.Controllers;

[ApiController]
[Route("api/seguros")]
public class SegurosController : ControllerBase
{
    // “Seguros” en memoria. Para evidencia, se crea uno “dummy” por producto.
    private static readonly List<Seguro> seguros = new();
    private static int id = 1;

    [HttpGet("{idSeguro}")]
    public IActionResult Obtener(int idSeguro)
    {
        var s = seguros.FirstOrDefault(x => x.Id == idSeguro);
        if (s == null) return NotFound();
        return Ok(s);
    }

    // Endpoint opcional para crear un seguro (si quieres evidenciar creación explícita)
    [HttpPost]
    public IActionResult Crear([FromBody] Seguro seguro)
    {
        seguro.Id = id++;
        seguros.Add(seguro);
        return Ok(seguro);
    }
}
