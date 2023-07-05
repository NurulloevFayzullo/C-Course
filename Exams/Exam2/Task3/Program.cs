List<User> users = new List<User>();
var user1 = new User()
{
    FirstName = "Fayzullo",
    LastName = "Nurulloev",
    _Username="fayz",
    _Password="fayz123"
};

var user2 = new User()
{
    FirstName = "Fayzullo2",
    LastName = "Nurulloev2",
    _Username="fayz2",
    _Password="fayz123"
};
var user3 = new User()
{
    FirstName = "Fayzullo3",
    LastName = "Nurulloev3",
    _Username="fayz3",
    _Password="fayz123"
};
var user4 = new User()
{
    FirstName = "Fayzullo4",
    LastName = "Nurulloev4",
    _Username="fayz4",
    _Password="fayz123"
};
var user5 = new User()
{
    FirstName = "Fayzullo5",
    LastName = "Nurulloev5",
    _Username="fayz5",
    _Password="fayz123"
};
users.Add(user1);
users.Add(user2);
users.Add(user3);
users.Add(user4);
users.Add(user5);

while (true)
{
    System.Console.WriteLine("-------------------------------------------------------------------------");
    System.Console.Write("Enter your Username :");
    string username=Console.ReadLine();
    System.Console.Write("Enter your Password :");
    string password=Console.ReadLine();
    for (int i = 0; i < users.Count; i++)
    {
    users[i].Login(username, password);
    }
  
}

class User
{
    public string FirstName;
    public string LastName;
    public string _Username;
    public string _Password;
    public void GetInfo()
    {
        System.Console.WriteLine($"{FirstName} {LastName} ");
    }
    public void Login(string username, string password)
    {
        if (_Username == username && _Password == password)
        {
          System.Console.WriteLine($"Login successful! Welcome mr {FirstName} {LastName}");    
        } 
        else{
            System.Console.WriteLine("Login failed");
        }
    }
}
