using System.Reflection.Emit;
using System.Text;

public class Assignment
{
    private string _name;
    private string _topic;

    public Assignment(string nameinput, string topicinput)

    {
        _name = nameinput;
        _topic = topicinput;
    }
    
    public string GetSummary()
    {


        return ($"{_name} --- {_topic}");
    }
}