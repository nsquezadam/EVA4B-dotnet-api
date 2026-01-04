var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

var app = builder.Build();

// (Opcional) 
// app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
