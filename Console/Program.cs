// See https://aka.ms/new-console-template for more information
using Data;
using Entities.Entities;
using Logic.Logic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Hello, Console!");

var builder = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json", false, true);
var config = builder.Build();
var connectionString = config.GetConnectionString("CVContext");

var services = new ServiceCollection();
services = ServiceContext.AddDbContextServiceFromConnString(services, connectionString);
var serviceProvider = services.BuildServiceProvider();

try
{
    Console.WriteLine("Insertando Producto...");
    var newCurriculum = new ProductItem();
    var curriculumLogic = new ProductLogic(serviceProvider);
    newCurriculum.Id = 0;
    newCurriculum.IdWeb = Guid.NewGuid();
    newCurriculum.InsertDate = DateTime.Now;
    newCurriculum.UpdateDate = null;
    newCurriculum.IsActive = true;
    newCurriculum.IsPublic = true;
    curriculumLogic.InsertProductItem(newCurriculum);
    Console.WriteLine("Producto insertado...");
}
catch (Exception e)
{
    Console.WriteLine("Ups...");
}