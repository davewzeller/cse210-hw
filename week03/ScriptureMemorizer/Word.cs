public class Word
{
    private readonly string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // Mark these words as hidden
    public void Hide() => _isHidden = true;

    // Indicates whether this word is hidden
    public bool IsHidden => _isHidden;

    // Returns either underscores or the actual word
    public string GetDisplayText() =>
        _isHidden ? new string('_', _text.Length) : _text;
}