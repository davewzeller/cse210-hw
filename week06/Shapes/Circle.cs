public class Circle : Shapes
{
    private double _radius;

    public override double GetArea()
    {

        return _radius * _radius * Math.PI;

    }

}