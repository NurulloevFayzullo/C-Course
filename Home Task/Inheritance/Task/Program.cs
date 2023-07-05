using Task;

var user = new Users();
for (int i = 0; i < 3; i++)
{
    var user1=new Users();
    System.Console.WriteLine($"User {i+1}");
 user1.Name=Console.ReadLine();
user.NameList.Add(user1);
}
foreach (var us in user.NameList)
{
    System.Console.WriteLine(us.ToString());
}
