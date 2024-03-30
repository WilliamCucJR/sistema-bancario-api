using Microsoft.EntityFrameworkCore;
using sistema_bancario_api.Data;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

var allowedOrigins = configuration["AllowedOrigins"];
if (string.IsNullOrEmpty(allowedOrigins))
{
    throw new Exception("AllowedOrigins is not set in the configuration");
}

// Agrega CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowMyOrigin",
        builder => builder.WithOrigins(allowedOrigins) // Usa la URL de la configuración
                           .AllowAnyMethod()
                           .AllowAnyHeader());
});

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.PropertyNamingPolicy = null;
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<UserLoginTable>(options =>
{
    options.UseOracle(builder.Configuration.GetConnectionString("OracleDB"));
}
);

builder.Services.AddDbContext<MonedaTable>(options =>
{
    options.UseOracle(builder.Configuration.GetConnectionString("OracleDB"));
});

builder.Services.AddDbContext<TipoCuentaTable>(options =>
{
    options.UseOracle(builder.Configuration.GetConnectionString("OracleDB"));
});

builder.Services.AddDbContext<TipoDocumentoTable>(options =>
{
    options.UseOracle(builder.Configuration.GetConnectionString("OracleDB"));
});

builder.Services.AddDbContext<BancoTable>(options =>
{
    options.UseOracle(builder.Configuration.GetConnectionString("OracleDB"));
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowMyOrigin");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
