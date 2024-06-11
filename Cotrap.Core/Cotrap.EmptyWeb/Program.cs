using Cotrap.Core.Allenamento;
using Cotrap.Core.Interfacce;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddSingleton<IGestioneAtleta, GestioneAtletaMemoria>();
//builder.Services.AddTransient<IGestioneAtleta, GestioneAtletaMemoria>();
builder.Services.AddScoped<IGestioneAtleta, GestioneAtletaMemoria>();
builder.Services.AddScoped<IGestioneOspiti, GestioneOspitiDatabase>();
builder.Services.AddScoped<IClock, CotrapClock>();


var app = builder.Build();

//IGestioneAtleta gestioneAtleta = new GestioneAtletaMemoria();


app.MapGet("/", (IGestioneAtleta gestioneAtleta) => {
    var conteggio = gestioneAtleta.EstraiAtleti().Count();
    return $"Hello World! {conteggio}"; 
});

app.Run();
