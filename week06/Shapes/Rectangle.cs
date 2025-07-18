public class Rectangle : Shape
{
    private double _side1;
    private double _side2;

    public Rectangle(string colorinput, double side1Input, double side2Input) : base(colorinput)
    {
        _side1 = side1Input;
        _side2 = side2Input;
    }
    public override double GetArea()
    {

        return _side1 * _side2;

    }

}