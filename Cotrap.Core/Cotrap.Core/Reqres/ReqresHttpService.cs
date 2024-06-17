

using Cotrap.Core.RandomUserMe.ViewModels;
using Cotrap.Core.Reqres.Interfacce;
using System.Net.Http.Json;

namespace Cotrap.Core.Reqres;

public class ReqresHttpService : IReqres
{

    private HttpClient? _clientHttp;
    private string _baseUrl = "https://reqres.in/api/";
    
   

    public ReqresHttpService(HttpClient httpClient)
    {
        _clientHttp = httpClient;

        _clientHttp.BaseAddress = new Uri(_baseUrl);
    }

    public async Task<Person[]?> GetPeopleAsync()
    {
        if (_clientHttp == null)
        {
            throw new Exception("Client Http non inizializzato");
        }

        var response = await _clientHttp.GetAsync("users?page=2/");
        if (response.IsSuccessStatusCode)
        {
            var peopleData = await response.Content.ReadFromJsonAsync<Reqres>();
            return peopleData?.data;
        }
        else
        {
            return null;
        }
    }

    public async Task<IEnumerable<ViewModelPersona>?> GetPeopleViewModel()
    {
        if (_clientHttp == null)
        {
            throw new Exception("Client Http non inizializzato");
        }

        var response = await _clientHttp.GetAsync("users?page=2/");
        if (response.IsSuccessStatusCode)
        {
            var peopleData = await response.Content.ReadFromJsonAsync<Reqres>();
            var people =  peopleData?.data;

            return people?.Select(p => new ViewModelPersona
            {
                 Id = p.id.ToString(),
                 NomeCompleto = $"{p.first_name} {p.last_name}",
                 Indirizzo = p.email,
            });
        }
        else
        {
            return null;
        }
    }

    public async Task RegisterPerson(RegisterVM registerVM)
    {
        if (_clientHttp == null)
        {
            throw new Exception("Client Http non inizializzato");
        }

       
        var response = await _clientHttp.PostAsJsonAsync("register/", registerVM);

        if (response.IsSuccessStatusCode)
        {
            var registrationResponse = await response.Content.ReadFromJsonAsync<RegistrationResponse>();

            if (registrationResponse is not null)
            {
                Console.WriteLine($"Id: {registrationResponse.id} Token: {registrationResponse.token}");
            }
            
        }
        else
        {
            
        }

    }



    //public async Task<Reqres?> GetReqresData()
    //{
    //    if (_clientHttp == null)
    //    {
    //        throw new Exception("Client Http non inizializzato");
    //    }

    //    var response = await _clientHttp.GetAsync("");
    //    if (response.IsSuccessStatusCode)
    //    {
    //        return await response.Content.ReadFromJsonAsync<Reqres>();
    //    }
    //    else
    //    {
    //        return null;
    //    }
    //}

}
