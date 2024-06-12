using Cotrap.Core.Allenamento;
using Cotrap.Core.Interfacce;
using Cotrap.Core.RandomUserMe;
using Cotrap.Core.RandomUserMe.Interfacce;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddSingleton<IGestioneAtleta, GestioneAtletaMemoria>();
//builder.Services.AddTransient<IGestioneAtleta, GestioneAtletaMemoria>();
builder.Services.AddScoped<IGestioneAtleta, GestioneAtletaMemoria>();
builder.Services.AddScoped<IGestioneOspiti, GestioneOspitiDatabase>();
builder.Services.AddScoped<IClock, CotrapClock>();
builder.Services.AddScoped<IRandomUserData, ServizioDatiHttp>();


var app = builder.Build();

//IGestioneAtleta gestioneAtleta = new GestioneAtletaMemoria();


app.MapGet("/", async (IGestioneAtleta gestioneAtleta, IRandomUserData randomUserData) => {
    var conteggio = gestioneAtleta.EstraiAtleti().Count();
    var response = await randomUserData.GetRandomUserData();

    if(response is null)
    {
        return $"Hello World! {conteggio}";
    } else
    {
        if(response.Results is not null)
        {
            var email = response.Results[0].email;
            return $"Hello World! {conteggio} {email}";
        } else
        {
            return $"Hello World! {conteggio}";
        }
        
    }
});

app.Run();
