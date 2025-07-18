public abstract class Shape
{
    private string _color;

    public Shape(string colorinput)
    {
        
        _color = colorinput;
    }

    public string GetColor()
    {

        return _color;
    }

    public void SetColor(string colorinput)
    {
        _color = colorinput;
    }
    public abstract double GetArea();
//    {


 //   }


}