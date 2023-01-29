using System;

class BreathingActivity : Activity 
{
    List<string> prompt;

    public BreathingActivity() : base()
    {
        setActivityName("Breathing Activity");

        setDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");

        prompt = new List<string>
        {
            "Breathe in",
            "Breathe out"
        };
       

    }

    public void runActivity()
    {
        runActivityParentStart();
        displayCountDown(5);
        displayPrompt();
        displayCountDown(5);
        displayPrompt();
        displayCountDown(5);
        displayPrompt();
        displayCountDown(5);
        displayPrompt();
        runActivityParentEnd();

    }

    public void displayPrompt()
    {
       Console.Clear();
       Console.WriteLine("Consider the following:");
       Console.WriteLine();

       int randomIndex = new Random().Next(0, prompt.Count());
       Console.WriteLine(prompt[randomIndex]);
       Console.WriteLine();

       
}


}