using System.IO.Compression;

public class Fraction
{

   private int _bottom;
    private int _top;

    public Fraction()
    {
        _bottom = 1;
        _top = 1;
    }

    public Fraction(int wholenumber)
    {
        _top = wholenumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";

        return text;
    }

    public double getDesimal()
    {

        return (double)_top / (double)_bottom;

    }

}