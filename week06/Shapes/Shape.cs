public abstract class Shapes
{
    private string _color;

    public Shapes(string colorinput)
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