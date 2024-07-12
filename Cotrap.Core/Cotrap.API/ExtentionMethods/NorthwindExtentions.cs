namespace Cotrap.API.ExtentionMethods;

public static class NorthwindExtentions
{
    public static ClienteDettagliato ToClienteDettagliato(this Customer c)
    {
        return new ClienteDettagliato { Id = c.Id, Contatto = c.ContactName, IndirizzoCompleto = $"{c.Country} {c.City} {c.Address}", 
            Nome = c.CompanyName, 
            Telefono = c.Phone,
            Ordini = c.Orders.ToOrdini()
        };
    }

    public static IEnumerable<ClienteDettagliato> ToClienteDettagliatoList(this IEnumerable<Customer> customers)
    {
        var l = new List<ClienteDettagliato>();
        foreach (Customer c in customers)
        {
            l.Add(c.ToClienteDettagliato());
        }

        return l;
    }

    public static IEnumerable<DettaglioOrdine> ToDettaglioOrdineList(this IEnumerable<OrderDetail> orderDetails)
    {
        var l = new List<DettaglioOrdine>();
        foreach (OrderDetail o in orderDetails)
        {
            l.Add(new DettaglioOrdine { NomeProdotto = o.Product.ProductName, PrezzoUnitario = o.UnitPrice, Quantita = o.Quantity, Sconto = o.Discount });
        }
        return l;
    }

    public static IEnumerable<Ordine> ToOrdini(this IEnumerable<Order> orders)
    {
        var l = new List<Ordine>();
        foreach (Order o in orders)
        {
            var ordine = new Ordine { Id = o.Id, Corriere = o.ShipName, Data = o.OrderDate, 
                Trasporto = o.Freight, DettagliOrdini = o.OrderDetails.ToDettaglioOrdineList() };
            l.Add(ordine);
        }

        return l;
    }

}