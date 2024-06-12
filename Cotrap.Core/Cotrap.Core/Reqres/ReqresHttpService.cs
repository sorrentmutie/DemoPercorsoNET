

using Cotrap.Core.Reqres.Interfacce;
using System.Net.Http.Json;

namespace Cotrap.Core.Reqres;

public class ReqresHttpService : IReqres
{

    private HttpClient? _clientHttp;
    private string _baseUrl = "https://reqres.in/api/users?page=2";
    
   

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

        var response = await _clientHttp.GetAsync("");
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
