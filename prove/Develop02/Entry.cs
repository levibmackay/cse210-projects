class Entry
{
    private string _date;
    private string _prompt;
    private string _response;
    private string _mood; 
    public Entry(string date, string prompt, string response, string mood)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
        _mood = mood;
    }

    public string GetDisplayString()
    {
        return "Date: " + _date + "\nPrompt: " + _prompt + "\nResponse: " + _response + "\nMood: " + _mood;
    }

    public string GetSaveString()
    {
        return _date + "|" + _prompt + "|" + _response + "|" + _mood;
    }
}
