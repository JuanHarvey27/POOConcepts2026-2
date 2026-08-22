namespace Backend;

public class Hour
{
    //Fields
    private int _hour;
    private int _minute;
    private int _second;
    private int _millisecond;

    //Constructors
    public Hour()
    {
        Hour = 0;
        Minute = 0;
        Second = 0;
        Millisecond = 0;
    }
    public Hour(int hour)
    {
        Hour = hour;
        Minute = 0;
        Second = 0;
        Millisecond = 0;
    }
    public Hour(int hour, int minute)
    {
        Hour = hour;
        Minute = minute;
        Second = 0;
        Millisecond = 0;
    }
    public Hour(int hour, int minute, int second)
    {
        Hour = hour;
        Minute = minute;
        Second = second;
        Millisecond = 0;
    }
    public Hour(int hour, int minute, int second, int millisecond)
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
        return $"{Hour:D2}:{Minute:D2}:{Second:D2}.{Millisecond:D3}";
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
