public class Prompt
{
    private string _prompt;

    public Prompt(string prompt)
    {
        _prompt = prompt;
    }

     public string GetPrompt()
    {
        return $"\"{_prompt}";
    }
    
}