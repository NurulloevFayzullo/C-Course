namespace Task2.Person;

public class Person
{
    string name;
    string address;
    public Person(string name,string address)
    {
        this.name=name;
        this.address=address;
    }
    public string getName(){
        return name;
    }
    public string getAddress(){
        return address;
    }
    public void setAddress(string address){
        this.address=address;
    }
    public string toString(){
        return $"{name}({address})";
    }

}
