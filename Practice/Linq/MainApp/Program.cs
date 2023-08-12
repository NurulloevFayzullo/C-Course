// var Number= new List<int>{9,8,6,5};
// var result=from n in Number
// select new{
//     Number=n,SqrNo=n*n
// // };
// var list = new List<int> { 5, 3, 2, 54, 32, 5, 2 };
// var result = (from n in list
//               group n by n into gr
//               select new
//               {
//               Number=gr.Key,
//               Count=gr.Count()
//               }).ToList();

// var text = new List<string> { "a", "b", "c", "a", "a" };
// var result = (from n in text
//               group n by n into gr
//               select new
//               {
//             Character =gr.Key,
//             times=gr.Count()
//               }).ToList();

// var week = Enum.GetValues(typeof(DayOfWeek));
// foreach (var item in week)
// {
//     System.Console.WriteLine(item);
// }
// Console.WriteLine("How many records you want to display");
// var n=Convert.ToInt32(Console.ReadLine());
// var list = new List<int>{5, 7, 13, 24, 6, 9, 8, 7};
// var result= (from f in list
// select f).ToList().Take(n);

// System.Console.WriteLine("-----------------------------");
// var number = new List<int>{1,2,3,4,5,6,7,8,9,10};
// var random = new Random();
// var result = (from n in number
//     orderby random.Next()
//     select n);

// var text="pandann";
// var result =(from t in text
// group t by t into gr
// orderby gr.Count() descending
// select gr.Key).Take(1);

// var text = new List<string>{"abc","abc","asd","dsa","bds","bds"};
// var result= (from t in text
//  group t by t into gr
// where gr.Count()<2 
//  select gr.Key);

var text ="AdbedwCZ DDD ggmkn HHH kmdgpsg OIIO";
var result = (from t in text
orderby t
select t);
foreach (var item in result)
{
    System.Console.WriteLine(item);
}