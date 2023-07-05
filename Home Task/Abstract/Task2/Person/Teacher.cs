namespace Task2.Person;

public class Teacher : Person
{
    int numCourses = 0;
    List<string> courses;
    public Teacher(string name, string address) : base(name, address)
    {
        courses = new List<string>();
    }
    public bool addCourse(string course)
    {
        bool b = false;
        foreach (var item in courses)
        {
            if (item != course)
            {
                courses.Add(course);
                b = true;
            }
        }
        return b;
    }
    public bool removeCourse(string course)
    {
        bool b = false;
        for (int i = 0; i < courses.Count; i++)
        {
            if (courses[i] == course)
            {
                courses.RemoveAt(i);
                b = true;
            }
        }
        return b;
    }
    public string toString()
    {
        return $"Teacher: {base.toString}";
    }
}
