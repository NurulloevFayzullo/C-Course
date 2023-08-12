var words = new List<string>{"apple","banana","cherry","date","elderberry"};
var result = (from w in words
orderby w.Length descending
select w);
foreach (var item in result)
{
    System.Console.WriteLine(item);
}