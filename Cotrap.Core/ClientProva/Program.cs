
using ClientProva.Models;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

var db = new NorthwindContext();
//var customers = (await db.Customers.Include(c => c.Orders)
//    .ThenInclude(o => o.OrderDetails)
//    .ThenInclude(od => od.Product)
//    .ThenInclude(p => p.Supplier)
//    .ToListAsync())
//    .ToClienteDettagliatoList();

//foreach (var c in customers)
//{
//    Console.WriteLine(c);
//}

//var customer = await db.Customers.Include(c => c.Orders)
//    .ThenInclude(o => o.OrderDetails)
//    .ThenInclude(od => od.Product)
//    .FirstOrDefaultAsync(x => x.CustomerId == "ALFKI");

//if (customer is not null)
//{
//    var cliente = customer.ToClienteDettagliato();
//    if(cliente is not null)
//    {
//        Console.WriteLine(cliente);
//    }
    
//}
