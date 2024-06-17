using Cotrap.Core.RandomUserMe.Interfacce;
using Cotrap.Core.RandomUserMe.ViewModels;
using System.Net.Http.Json;
using Cotrap.Core.RandomUserMe.ExtensionMethods; 

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

    public async Task<ViewModelPersona?> GetViewModelPersona()
    {
        if (_clientHttp == null)
        {
            throw new Exception("Client Http non inizializzato");
        }

        var response = await _clientHttp.GetAsync("");
        if (response.IsSuccessStatusCode)
        {
            var data = await response.Content.ReadFromJsonAsync<RandomUserData>();
            if ((data is null || data.Results == null || (data.Results is not null && data.Results.Length == 0)))
            {
                return null;
            }
            else
            {
                var person = data?.Results?[0];
                return person?.ConvertToViewModel();

            }
        } else         {
            return null;
        }
    }
}
