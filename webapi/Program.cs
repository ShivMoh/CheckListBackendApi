using Microsoft.EntityFrameworkCore;
using webapi.datacontext;

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;
var configuration = builder.Configuration;

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("local"), sqlServerOptionsAction: sqlOptions => { sqlOptions.EnableRetryOnFailure(); });
});

// builder.Services.AddCors(options =>
// {   
//     options.AddDefaultPolicy(
//         builder =>
//         {
//             builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
//         });
// });

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseCors();
app.UseAuthorization();
app.MapControllers();

app.Run();
