using System.Reflection.Emit;
using System.Text;

public class Activity

{

    private string _name;
    private string _discription;
    private int _duration;


    public Activity(string name, string desciption)
    {
        _name = name;
        _discription = desciption;

    }

    public void DisplayStart()
    {


    }

    public void DisplayEnd()
    {


    }

    protected int GetDuration() => _duration;

    protected void ShowSpinner(int seconds)

    {
        for (int i = 0; i < seconds; i++)
        {

            Console.WriteLine(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);

        }
        Console.WriteLine();
    }

}