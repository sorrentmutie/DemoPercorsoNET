using Cotrap.Core.RandomUserMe;
using Cotrap.Core.RandomUserMe.Interfacce;
using System.ComponentModel.DataAnnotations;

namespace Cotrap.Test;

[TestClass]
public class TestRandomUserMe
{
    [TestMethod]
    public async Task CheckRandomUserDataNotNull()
    {
        IRandomUserData randomUserData = new ServizioDatiHttp();
        var data = await randomUserData.GetRandomUserData();
        Assert.IsNotNull(data);
    }
}
