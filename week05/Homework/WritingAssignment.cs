using System.Reflection.Emit;
using System.Text;
public class WritingAssignment : Assignment
{
    private string _title;
    

    public WritingAssignment(string nameinput, string topicinput, string titleInput)
    : base(nameinput, topicinput)
    {
        _title = titleInput;
        
    }

    public string GetWritingInformation()
    {
        return $"Title: {_title}";
    }


}