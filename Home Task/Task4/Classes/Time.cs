namespace Classes;
public class Time
{
    int _hour;
    int _minute;
    int _second;

    public Time()
    {

    }
    public Time(int hour, int minute, int second)
    {
        if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59 && second >= 0 && second <= 59)
        {
            _hour = hour;
            _minute = minute;
            _second = second;
        }
    }
    public int getHour { get { return _hour; } }
    public int getMinute { get { return _minute; } }
    public int getSecond { get { return _second; } }
    public void setHour(int hour) { _hour = hour; }
    public void setMinute(int minute) { _minute = minute; }
    public void setSecond(int second) { _second = second; }
    public void toString()
    {
        System.Console.WriteLine($"{_hour}:{_minute}:{_second}");
    }
    public void setTime(int hour, int minute, int second)
    {
        if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59 && second >= 0 && second <= 59)
        {
            _hour = hour;
            _minute = minute;
            _second = second;
        }
    }
    public Time nextSecond()
    {
        ++_second;
        if (_second >= 60)
        {
            _second = 0;
            ++_minute;
        }
        if (_minute >= 60)
        {
            _minute = 0;
            ++_hour;
        }
        if (_hour >= 24)
        {
            _hour = 0;
        }
        return this;
    }
}