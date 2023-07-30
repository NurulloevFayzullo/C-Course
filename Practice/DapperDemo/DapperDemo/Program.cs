using System;
var contactService = new ContactService();
var t = contactService.GetContactById(1);
System.Console.WriteLine(t);
// while (true)
// {
//     System.Console.WriteLine("\n Commands : \n r - all records \n c - for create \n u - for update \n d - for delete");
//     var command = Console.ReadLine();
//     if (command == "r")
//     {
//         foreach (var item in contactService.GetContacts())
//         {
//             System.Console.WriteLine($"Id={item.Id} Name={item.Name} Phone={item.Phone}");
//         }
//     }
//     else if (command == "c")
//     {
//         Create();
//     }
//     else if (command == "d")
//     {
//         System.Console.Write("Enter id which you wanna delete =");
//         var id = Convert.ToInt32(Console.ReadLine());
//         contactService.DeleteContact(id);
//     }
//     else if (command == "u")
//     {
//         Update();
//     }
// }

// void Create()
// {
//     var contact = new Contact();
//     System.Console.WriteLine("Enter Id=");
//     contact.Id = Convert.ToInt32(Console.ReadLine());
//     System.Console.WriteLine("Enter Name=");
//     contact.Name = Console.ReadLine();
//     System.Console.WriteLine("Enter Phone=");
//     contact.Phone = Console.ReadLine();
//     contactService.AddContact(contact);
// }

// void Update()
// {
//     System.Console.WriteLine("Enter id which you wanna edit: Id=");
//     var id = Convert.ToInt32(Console.ReadLine());

//     var existing = contactService.GetContactById(id);
//     System.Console.WriteLine($"Name Before : {existing.Name} after :");
//     var inputName = Console.ReadLine();
//     if (String.IsNullOrEmpty(inputName) == false)
//     {
//         existing.Name = inputName;
//     }
//     System.Console.WriteLine($"Phone Before : {existing.Phone} after :");
//     var inputPhone = Console.ReadLine();
//     if (String.IsNullOrEmpty(inputPhone) == false)
//     {
//         existing.Phone = inputPhone;
//     }
//     contactService.UpdateContact(existing);
// }
////////////////////////////////////////////////////////////////////////////////////////////////////////
var todoService=new TodoService();

// var todo=new Todo();
// todo.Id=2;
// todo.TaskName="ASDFAD";
// todo.Status=Status.Complited;

// todoService.AddTodo(todo);
// foreach (var item in todoService.GetTodo())
// {
//     System.Console.WriteLine(item.Id);
//     System.Console.WriteLine(item.TaskName);
//     System.Console.WriteLine(item.Status);

// }
