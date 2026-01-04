var builder = WebApplication.CreateBuilder(args);

// ✅ Necesario para Controllers
builder.Services.AddControllers();

var app = builder.Build();

// (Opcional) Si te molesta el warning, deja comentado:
// app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
