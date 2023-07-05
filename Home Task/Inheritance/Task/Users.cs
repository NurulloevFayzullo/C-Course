namespace Task;


public class Users : Person
{
 public List<Person> NameList;
 public Users()
 {
  NameList=new List<Person>();
 }
  public override string ToString(){
    return $"Hello! My name is {Name}";
 }  
}
