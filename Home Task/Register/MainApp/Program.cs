// 1
// var sd= new List<int>{67,92,153,15}.Where(e=>e>30 && e<100);

// 2
// var list = new List<string>{"computer","usb"}.Where(e=>e.Length==5).Select(e=>e.ToUpper());

// 3
// var list = new List<string> { "mum", "amsterdum", "bloom" };
// var result = from s in list
//              where s.StartsWith("a") && s.EndsWith("m")
//              select s;

// 4
// var list = new List<int> { 78, -9, 0, 23, 54, 21, 7, 86 };
// var result = (from f in list
//              orderby f descending
//              select f).Take(5);

//5 
// var list = new List<int>{7,2,30};
// var result=from f in list
// where f*f > 20
// select f;

//6
// var list = new List<string> { "learn","current","deal"};
// var result = list.Select(e=>e.Replace("ea","*"));

// 7
// var list= new List<string>{"plane", "ferry", "car", "bike"};
// var result = list.Where(o=>o.Contains("e"));
foreach (var item in result)
{
    System.Console.WriteLine(item);
}