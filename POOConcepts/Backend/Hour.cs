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
        _hour = 0;
        _minute = 0;
        _second = 0;
        _millisecond = 0;
    }
    public Hour(int hour)
    {
        _hour = hour;
        _minute = 0;
        _second = 0;
        _millisecond = 0;
    }
    public Hour(int hour, int minute)
    {
        _hour = hour;
        _minute = minute;
        _second = 0;
        _millisecond = 0;
    }
    public Hour(int hour, int minute, int second)
    {
        _hour = hour;
        _minute = minute;
        _second = second;
        _millisecond = 0;
    }
    public Hour(int hour, int minute, int second, int millisecond)
    {
        _hour = hour;
        _minute = minute;
        _second = second;
        _millisecond = millisecond;
    }
    //Properties

    //Public Methods

    //Private Methods

}
