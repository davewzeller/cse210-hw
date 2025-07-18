public class Circle : Shape
{
    private double _radius;

    public Circle(string colorinput, double radiusInput) : base(colorinput)
    {
        _radius = radiusInput;
    }
    public override double GetArea()
    {

        return _radius * _radius * Math.PI;

    }

}