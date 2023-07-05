public class Date
{

    int _year;
    int _month;
    int _day;

    
    public Date(int day, int month, int year)
    {
        if ( day >= 1 && day <= 31 && month >= 1 && month <= 12 && year >= 1000 && year <= 9999 )
        {
            _day = day;
            _month = month;
            _year = year; 
        }
        else
        {
            System.Console.WriteLine("Day, month or year was in incorrect format");
        }
    }

    public int Year { get{return _year;} set{_year = value;} }
    public int Month {  get{return _month;} set{_month = value;} }
    public int Day {  get{return _day;} set{_day = value;} }

    public string ToString ()
    {
        return $"{_day}/{_month}/{_year}";
    }

    public void SetDate(int day, int month, int year)
    {
        if ( day >= 1 && day <= 31 && month >= 1 && month <= 12 && year >= 1000 && year <= 9999 )
        {
            _day = day;
            _month = month;
            _year = year; 
            System.Console.WriteLine("Updated successfully");
        }
        else
        {
            System.Console.WriteLine("Day, month or year was in incorrect format");
        }
    }
}