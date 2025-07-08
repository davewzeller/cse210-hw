using System.Reflection.Emit;
using System.Text;
public class MathAssignment : Assignment
{
    private string _textbooksection;
    private string _problems;

    public MathAssignment(string nameinput, string topicinput, string textbooksectioninput, string problemsInput)
    : base(nameinput, topicinput)
    {
        _textbooksection = textbooksectioninput;
        _problems = problemsInput;
    }

    public string GetHomeWorkList()
    {
        return $"Math Topic: {_textbooksection} and Problems: {_problems}";
    }


}