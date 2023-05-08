public class Prompt
{
    private void NicePrint(string item)
    {
        Console.WriteLine("--------------------------------");
        Console.WriteLine($"{item}");
        Console.WriteLine("--------------------------------");
    }

    List<string> _prompts = new List<string>();


    public Prompt()
    {
        _prompts.Add("How was your day?");
        _prompts.Add("Where did you go today?");
        _prompts.Add("What am I grateful for today?");
        _prompts.Add("What was the worst thing that happened today?");
        _prompts.Add("What was the most interesting thing I saw or heard today?");
        _prompts.Add("What was the best thing that happened today?");
        _prompts.Add("What did I learn today?");
        _prompts.Add("What did I do today that I am proud of?");
        _prompts.Add("What was the most surprising thing that happened today?");
        _prompts.Add("What was the most fun thing I did today?");
        _prompts.Add("What was the most challenging thing I faced today?");
        _prompts.Add("What held me back from accomplishing everything I wanted to do today?");
        _prompts.Add("What would I change about today if I could?");
        _prompts.Add("What is something I learned today?");
    }

     public string GetPrompt()
    {
        return $"\"{_prompts}";
    }
   

   


}