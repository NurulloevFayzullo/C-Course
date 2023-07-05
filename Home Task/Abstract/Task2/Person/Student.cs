namespace Task2.Person;

public class Student : Person
{
    int numCourses = 0;
    List<string> courses;
    List<int> grades;
  
    public Student(string name,string address)
     : base(name, address)
    {
        courses = new List<string>();
        grades = new List<int>();
    }
    public void addCourseGrade(string course,int grade){
    courses.Add(course);
    grades.Add(grade);
    }
    public void printGrade(){
        foreach (var grade in grades)
        {
            System.Console.WriteLine(grade);
        }
    }
    public double getAverageGrade(){
        return grades.Average();
    }
    public string toString(){
        return $"Student: {base.toString()}";
    }
}
