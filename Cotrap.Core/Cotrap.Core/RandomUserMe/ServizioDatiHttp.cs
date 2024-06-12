using Cotrap.Core.RandomUserMe.Interfacce;
using System.Net.Http.Json;

namespace Cotrap.Core.RandomUserMe;

public class ServizioDatiHttp : IRandomUserData
{
    private HttpClient? _clientHttp;
    private string _baseUrl = "https://randomuser.me/api/";


    public ServizioDatiHttp()
    {
        _clientHttp = new HttpClient() { 
            BaseAddress = new Uri(_baseUrl)
        };
    }

    public async Task<RandomUserData?> GetRandomUserData()
    {
        if(_clientHttp == null)
        {
            throw new Exception("Client Http non inizializzato");
        }

        var response = await _clientHttp.GetAsync("");
        if(response.IsSuccessStatusCode)
        {
            return await response.Content.ReadFromJsonAsync<RandomUserData>();

        } else
        {
            return null;
        }
    }
}
