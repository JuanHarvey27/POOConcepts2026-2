namespace Backend;

public class Time
{
    //Fields
    private int _hour;
    private int _minute;
    private int _second;
    private int _millisecond;

    //Constructors
    public Time()
    {
        Hour = 0;
        Minute = 0;
        Second = 0;
        Millisecond = 0;
    }
    public Time(int hour)
    {
        Hour = hour;
        Minute = 0;
        Second = 0;
        Millisecond = 0;
    }
    public Time(int hour, int minute)
    {
        Hour = hour;
        Minute = minute;
        Second = 0;
        Millisecond = 0;
    }
    public Time(int hour, int minute, int second)
    {
        Hour = hour;
        Minute = minute;
        Second = second;
        Millisecond = 0;
    }
    public Time(int hour, int minute, int second, int millisecond)
    {
        Hour = hour;
        Minute = minute;
        Second = second;
        Millisecond = millisecond;
    }
    //Properties

    public int Hour { 
        get=>_hour; 
        set=>_hour = ValidHour(value); 
    }
    public int Minute { 
        get=>_minute; 
        set=>_minute = ValidMinute(value); 
    }
    public int Second { 
        get=>_second; 
        set=>_second = ValidSecond(value); 
    }
    public int Millisecond { 
        get=>_millisecond; 
        set=>_millisecond = ValidMillisecond(value); 
    }

    //Public Methods
    public override string ToString()
    {
        string period = Hour < 12 ? "AM" : "PM";
        int DisplayHour = Hour % 12;
        return $"{DisplayHour:D2}:{Minute:D2}:{Second:D2}.{Millisecond:D3} {period}";
    }
    public int ToMilliseconds()
    {
        return ((Hour * 3600) + (Minute * 60) + Second)*1000 + Millisecond;
    }
    public int ToSeconds()
    {
        return ToMilliseconds() / 1000;
    }
    public int ToMinutes()
    {
        return ToSeconds() / 60;
    }
    public Time Add(Time other)
    {
        int totalMilliseconds = ToMilliseconds() + other.ToMilliseconds();
        int newMillisecond = totalMilliseconds % 1000;
        int totalSeconds = totalMilliseconds / 1000;
        int newSecond = totalSeconds % 60;
        int totalMinutes = totalSeconds / 60;
        int newMinute = totalMinutes % 60;
        int totalHours = totalMinutes / 60;
        int newHour = totalHours % 24; // The % 24 ensures the hour wraps around to 0-23
        return new Time(newHour, newMinute, newSecond, newMillisecond);
    }
    public bool IsOtherDay(Time other)
    {
        int totalMilliseconds = ToMilliseconds() + other.ToMilliseconds();
        int totalHours = totalMilliseconds / 3600000; // 3600000 milliseconds = 1 hour
        return totalHours >= 24;
    }
    //Private Methods
    private int ValidHour(int hour)
    {
        if (hour < 0 || hour > 23)
        {
            throw new Exception($"The Hour: {hour} is not valid");
        }
        return hour;
    }   
    private int ValidMinute(int minute)
    {
        if (minute < 0 || minute > 59)
        {
            throw new Exception($"The Minute: {minute} is not valid");
        }
        return minute;
    }
    private int ValidSecond(int second)
    {
        if (second < 0 || second > 59)
        {
            throw new Exception($"The Second: {second} is not valid");
        }
        return second;
    }
    private int ValidMillisecond(int millisecond)
    {
        if (millisecond < 0 || millisecond > 999)
        {
            throw new Exception($"The Millisecond: {millisecond} is not valid");
        }
        return millisecond;
    }
}
