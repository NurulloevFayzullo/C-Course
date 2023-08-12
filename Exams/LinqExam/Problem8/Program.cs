using Problem8.Class;

var customers = new List<Customer>
{
 new Customer { CustomerId = 1, Name = "Alice" },
 new Customer { CustomerId = 2, Name = "Bob" },
 new Customer { CustomerId = 3, Name = "Charlie" },
};
var orders = new List<Order>
{
 new Order { OrderId = 1, CustomerId = 1, Amount = 10 },
 new Order { OrderId = 2, CustomerId = 2, Amount = 20 },
 new Order { OrderId = 3, CustomerId = 1, Amount = 30 },
 new Order { OrderId = 4, CustomerId = 3, Amount = 40 },
 new Order { OrderId = 5, CustomerId = 2, Amount = 50 },
 new Order { OrderId = 6, CustomerId = 1, Amount = 60 },
};
var result = (
             from c in customers
              join o in orders 
              on c.CustomerId equals o.CustomerId 
              group o by o.CustomerId into gr
              select new {
               Id=gr.Key,
               Amount=gr.Sum(c => c.Amount),
              }).Take(2);
              foreach (var item in result)
              {
                System.Console.WriteLine(item);
              }