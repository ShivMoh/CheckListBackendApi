using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using webapi.datacontext;
using MapsterMapper;
using Mapster;
using System.Reflection;
using System.Net;
using Microsoft.AspNetCore.HttpOverrides;

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;
var configuration = builder.Configuration;

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var config = TypeAdapterConfig.GlobalSettings;
config.Scan(Assembly.GetExecutingAssembly());
services.AddSingleton(config);
services.AddScoped<IMapper, ServiceMapper>();

// builder.Services.AddDbContext<DataContext>(options =>
// {
//     options.UseSqlServer(builder.Configuration.GetConnectionString("local"), sqlServerOptionsAction: sqlOptions => { sqlOptions.EnableRetryOnFailure(); });
// });

var serverVersion = new MySqlServerVersion(new Version(8, 0, 35));

builder.Services.AddDbContext<DataContext>(
    options => {
        options.UseMySql(builder.Configuration.GetConnectionString("mysql"), serverVersion, mySqlOptionsAction: sqlOptions => {sqlOptions.EnableRetryOnFailure();});
    }
);

// builder.Services.Configure<ForwardedHeadersOptions>(options =>
// {
//     options.KnownProxies.Add(IPAddress.Parse("190.108.207.117"));
// });

builder.Services.AddCors(options =>
{   
    options.AddDefaultPolicy(
        builder =>
        {
            builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
        });
});

var app = builder.Build();

// app.UseForwardedHeaders(new ForwardedHeadersOptions
// {
//     ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
// });
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
} 

app.UseStaticFiles(new StaticFileOptions()
{
 FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), @"Resources")),
 RequestPath = new PathString("/Resources")
});


// app.UseHttpsRedirection();
app.MapGet("/", () => "this is running still");
app.UseRouting();
app.UseCors();
// app.UseAuthorization();
app.MapControllers();

app.Run();
