using Cotrap.Core.Allenamento;
using Cotrap.Core.Interfacce;
using Cotrap.Core.RandomUserMe;
using Cotrap.Core.RandomUserMe.Interfacce;
using Cotrap.Core.Reqres;
using Cotrap.Core.Reqres.Interfacce;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddSingleton<IGestioneAtleta, GestioneAtletaMemoria>();
//builder.Services.AddTransient<IGestioneAtleta, GestioneAtletaMemoria>();
builder.Services.AddScoped<IGestioneAtleta, GestioneAtletaMemoria>();
builder.Services.AddScoped<IGestioneOspiti, GestioneOspitiDatabase>();
builder.Services.AddScoped<IClock, CotrapClock>();
builder.Services.AddScoped<IRandomUserData, ServizioDatiHttp>();
builder.Services.AddScoped<IReqres, ReqresHttpService>();
builder.Services.AddScoped<HttpClient>();





var app = builder.Build();

//IGestioneAtleta gestioneAtleta = new GestioneAtletaMemoria();


app.MapGet("/", async (IGestioneAtleta gestioneAtleta, IRandomUserData randomUserData, IReqres reqres) => {
    var conteggio = gestioneAtleta.EstraiAtleti().Count();
    var response = await randomUserData.GetRandomUserData();
    var peopleData = await reqres.GetPeopleAsync();

    await reqres.RegisterPerson(new RegisterVM
    {
        email = "prova@gmail.com",
        password = "Password1234!"
    });

    //if (response is null)
    //{
    //    return $"Hello World! {conteggio}";
    //} else
    //{
    //    if(response.Results is not null)
    //    {
    //        var email = response.Results[0].email;
    //        return $"Hello World! {conteggio} {email}";
    //    } else
    //    {
    //        return $"Hello World! {conteggio}";
    //    }
        
    //}

    if(peopleData is not null)
    {
        return $"{peopleData[0].first_name}";
    }
    else
    {
        return "Non ci sono persone";
    }

});

app.Run();
