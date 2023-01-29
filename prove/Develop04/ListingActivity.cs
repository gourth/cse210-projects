using System;

class ListingActivity : Activity 
{
    List<string> prompt;

    public ListingActivity() : base()
    {
        setActivityName("Listing Activity");

        setDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        prompt = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

    }

    public void runActivity()
    {
        runActivityParentStart();
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

       Console.WriteLine("When you have something in mind, press enter to continue.");
       Console.ReadLine();
}


}