using System.Net.Http.Json;

Console.WriteLine("Hello, World!");
HttpClient client = new HttpClient();
var result = await client.GetAsync(new Uri("https://localhost:7024/customers/alfki"));
if (result != null)
{
    if (result.IsSuccessStatusCode)
    {
        var data = await result.Content.ReadFromJsonAsync<DettaglioCliente>();
        if(data != null)
        {
            Console.WriteLine($"{data.nome} {data.numeroTotaleOrdini}");
            
        }
    }
}

Console.ReadLine();