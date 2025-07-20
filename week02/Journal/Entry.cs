public class Entry
{
    public string _date { get; set; }
    public string _prompt { get; set; }
    public string _response { get; set; }

    public Entry(string prompt, string response)
    {
        _date = DateTime.Now.ToString("MMMM dd, yyyy - hh:mm tt");
        _prompt = prompt;
        _response = response;
    }

    public string GetDisplay()
    {
        return $"{_date}\nPrompt: {_prompt}\nResponse: {_response}\n";
    }

    public string Serialize()
    {
        return $"{_date} | {_prompt} | {_response}";
    }

    public static Entry Deserialized(string line)
    {
        string[] _parts = line.Split("|");
        return new Entry(_parts[1], _parts[2]) { _date = _parts[0] };
    }
}
   