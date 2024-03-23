using Microsoft.EntityFrameworkCore;
using sistema_bancario_api.Data;

var builder = WebApplication.CreateBuilder(args);


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


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
