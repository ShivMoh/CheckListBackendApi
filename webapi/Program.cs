using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
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

// var serverVersion = new MySqlServerVersion(new Version(8, 0, 35));

// builder.Services.AddDbContext<DataContext>(
//     options => {
//         options.UseMySql(builder.Configuration.GetConnectionString("aws_sql"), serverVersion, mySqlOptionsAction: sqlOptions => {sqlOptions.EnableRetryOnFailure();});
//     }
// );
builder.Services.AddCors(options =>
{   
    options.AddDefaultPolicy(
        builder =>
        {
            builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
        });
});

var app = builder.Build();

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

app.UseHttpsRedirection();
app.UseRouting();
app.UseCors();
app.UseAuthorization();
app.MapControllers();

app.Run();
