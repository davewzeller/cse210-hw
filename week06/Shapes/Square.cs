public class Square : Shape
{
    private double _side;

    public Square(string colorinput, double sideInput) : base(colorinput)
    {
        _side = sideInput;
    }
    public override double GetArea()
    {

        return _side * _side;

    }

}