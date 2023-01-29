using System;

class ReflectingActivity : Activity 
{
    List<string> prompt, questions;

    public ReflectingActivity() : base()
    {
        setActivityName("Reflecting Activty");

        setDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

        prompt = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?" 
            
        };
    }

    public void runActivity()
    {
        runActivityParentStart();
        displayPrompt();
        displayQuestions();
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

public void displayQuestions()
{
    List<int> indexes = new List<int>();

    // for (int i = 0, i < 4; i++)
    // {
    //     int randomInt = new Random().Next(0, questions.Count());
    //     while (indexes.Contains(randomInt))
    //     {
    //         randomInt = new Random().Next(0, questions.Count());
    //     }
    //     indexes.Add(randomInt);
    // }
    Console.Clear();
    Console.WriteLine("Now ponder on each of the following questions as they relate to this experience");
    displayCountDown(5);

    foreach (int index in indexes)
    {
        Console.Write(questions[index]);
        displaySpinner((getUserSessionLengthInput() / indexes.Count()));
        Console.WriteLine();
    }
}}