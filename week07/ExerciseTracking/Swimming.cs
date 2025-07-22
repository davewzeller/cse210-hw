public class Swimming : Activity
{
    private double _laps;
    

    public Swimming(string date, int minutes, double laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance() => (_laps*50) / 1000;
    public override double GetSpeed() => (GetDistance() / GetMinutes()) * 60;

    public override double GetPace() => GetMinutes() / GetDistance();


}