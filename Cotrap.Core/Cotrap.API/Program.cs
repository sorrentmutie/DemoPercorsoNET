using AutoMapper;
using Cotrap.Data.Northwind.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("NorthwindContext");

builder.Services.AddDbContext<NorthwindContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddScoped<DbContext, NorthwindContext>();

builder.Services.AddAutoMapper(typeof(Program).Assembly); // Register AutoMapper using the Cotrap.API assembly

RegistraServizi(builder);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseExceptionHandler(ex =>
{
    ex.Run(async context =>
    {
        var exceptionHandlerPathFeature = context.Features.Get<IExceptionHandlerPathFeature>();
        var exception = exceptionHandlerPathFeature!.Error;
        await context.Response.WriteAsJsonAsync(new { error = "Errore sul server" });
        //await Results.Problem("Problemi serissimi").ExecuteAsync(context);
    });
});   
    


var customersGroup = app.MapGroup("/customers");

customersGroup.MapGet("/", async (IDataService<Customer, CustomerDTO, CustomerCreaDTO, string> service) =>
{
    return await service.GetAsync(null);
   
});

customersGroup.MapGet("/{id}", async (string id, IDataService<Customer, CustomerDTO, CustomerCreaDTO, string> service) => 
   await service.GetAsyncById(id) is CustomerDTO cust ?
      Results.Ok(cust) : Results.NotFound());

customersGroup.MapPost("/", async (CustomerCreaDTO customer, IDataService<Customer, CustomerDTO, CustomerCreaDTO, string> service) =>
{
    if(customer is null) return Results.BadRequest("Mancano i dati del customer");
    if (string.IsNullOrWhiteSpace(customer.Chiave)) return Results.BadRequest("Nome non valido");
    if (customer.Chiave.Length != 5) return Results.BadRequest("La chiave deve essere lunga 5 caratteri");
    var id = await service.AddNewWithId(customer);
    return Results.Created($"/customers/{id}", customer);
});

customersGroup.MapPut("/{id}", async (string id, CustomerDTO customerModificato, IDataService<Customer, CustomerDTO, CustomerCreaDTO, string> service) =>
{
    if (customerModificato is null) return Results.BadRequest("Mancano i dati del customer");
    if ( id != customerModificato.Id) return Results.BadRequest("Id non valido");
    if (customerModificato.Id.Length != 5) return Results.BadRequest("La chiave deve essere lunga 5 caratteri");
    var customerDTODb = await service.GetAsyncById(id);
    if(customerDTODb is null) return Results.NotFound();
    await service.Update(customerModificato);
    return Results.NoContent();
});

customersGroup.MapPatch("/{ id}",
  async (string id, CustomerDTO customerModificato, IDataService<Customer, CustomerDTO, CustomerCreaDTO, string> service) => {

      if (customerModificato is null) return Results.BadRequest("Mancano i dati del customer");
      if (id != customerModificato.Id) return Results.BadRequest("Id non valido");
      if (customerModificato.Id.Length != 5) return Results.BadRequest("La chiave deve essere lunga 5 caratteri");
      var customerDTODb = await service.GetAsyncById(id);
      if (customerDTODb is null) return Results.NotFound();

      if(customerModificato.Nome != null) customerDTODb.Nome = customerModificato.Nome;
      if(customerModificato.Indirizzo != null) customerDTODb.Indirizzo = customerModificato.Indirizzo;
      if(customerModificato.Contatto != null) customerDTODb.Contatto = customerModificato.Contatto;

      await service.Update(customerDTODb);
      return Results.NoContent();

  });

customersGroup.MapDelete("/{id}", async (string id, IDataService<Customer, CustomerDTO, CustomerCreaDTO, string> service) =>
{
    var customerDTODb = await service.GetAsyncById(id);
    if (customerDTODb is null) return Results.NotFound();
    await service.Delete(id);
    return Results.NoContent();
});


app.Run();

static void RegistraServizi(WebApplicationBuilder builder)
{
    builder.Services.AddScoped<IRepository<Category, int>, EFRepository<Category, int>>();
    builder.Services.AddScoped<IRepository<Order, int>, EFRepository<Order, int>>();
    builder.Services.AddScoped<IRepository<Customer, string>, EFRepository<Customer, string>>();
    builder.Services.AddScoped<IDataService<Order, OrdineDTO, OrdineCreaDTO, int>, ServizioOrdiniAPI>();
    builder.Services.AddScoped<IDataService<Customer, CustomerDTO, CustomerCreaDTO, string>, ServizioCustomerAPI>();
}
