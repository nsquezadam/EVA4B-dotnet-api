using Microsoft.AspNetCore.Mvc;
using AseguradoraNetApi.Models;

namespace AseguradoraNetApi.Controllers;

[ApiController]
[Route("api/clientes")]
public class ClientesController : ControllerBase
{
    private static readonly List<Cliente> clientes = new();
    private static int id = 1;

    [HttpPost]
    public IActionResult Crear([FromBody] Cliente cliente)
    {
        cliente.Id = id++;
        clientes.Add(cliente);
        return Ok(cliente);
    }

    [HttpGet]
    public IActionResult Listar() => Ok(clientes);
}
