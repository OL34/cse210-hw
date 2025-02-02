using System;

public class JournalPrompt
{
   public static string[] _prompt = {
"What was the best Part of your day?",
"What did you learn today?",
"What made you feel good today?",
"What was bad about today?",
"What was your favorite meal today?",
"Did you watch a show today? If so, what show?"
};
public List<string> _journalPrompt = new List<string>(_prompt);

public JournalPrompt()
{

}
public void Display()
    {
        var random = new Random();
        int index = random.Next(_journalPrompt.Count);
        string journalPrompt = _journalPrompt[index];
        Console.WriteLine($"\n{_journalPrompt}");
    }

    public string GetPrompt()
    {
        var random = new Random();
        int index = random.Next(_journalPrompt.Count);
        string journalPrompt = _journalPrompt[index];
        
        return journalPrompt;
    }
}