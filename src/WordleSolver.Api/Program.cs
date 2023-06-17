using Microsoft.Extensions.FileProviders;
using WordleSolver.Application;
using Mediator;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddApplication();
builder.Services.AddMediator();

var app = builder.Build();

Console.WriteLine($"ContentRoot Path: {builder.Environment.ContentRootPath}");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseStaticFiles(new StaticFileOptions 
{
    FileProvider = new PhysicalFileProvider(
        Path.Combine(app.Environment.ContentRootPath, "Resources"))
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();