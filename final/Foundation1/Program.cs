using System;
using System.Collections.Generic;
using System.IO;

enum GoalType
{
    Simple,
    Eternal,
    Checklist
}

class Goal
{
    public string Name { get; set; }
    public int Value { get; set; }
    public GoalType Type { get; set; }
    public int Progress { get; set; }
    public int Target { get; set; }

    public Goal(string name, int value, GoalType type, int progress = 0, int target = 0)
    {
        Name = name;
        Value = value;
        Type = type;
        Progress = progress;
        Target = target;
    }
}

class Program
{
    static List<Goal> Goals = new List<Goal>();
    static int Score = 0;

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("1. Show Goals");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Add Goal");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Save");
            Console.WriteLine("6. Load");
            Console.WriteLine("7. Exit");

            Console.Write("Choose an option: ");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ShowGoals();
                    break;
                case 2:
                    RecordEvent();
                    break;
                case 3:
                    AddGoal();
                    break;
                case 4:
                    Console.WriteLine("Score: " + Score);
                    break;
                case 5:
                    Save();
                    break;
                // case 6:
                //     Load();
                //     break;
                case 7:
                    return;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
    }

    static void ShowGoals()
    {
        
        Console.WriteLine("Goals: ");
        foreach (Goal goal in Goals)
        {
            if (goal.Type == GoalType.Simple)
            {
                Console.WriteLine("[{0}] {1} ({2} points)", goal.Progress == 0 ? " " : "X", goal.Name, goal.Value);
            }
            else if (goal.Type == GoalType.Eternal)
            {
                Console.WriteLine("{0} ({1} points per occurrence, {2} occurrences)", goal.Name, goal.Value, goal.Progress);
            }
            else if (goal.Type == GoalType.Checklist)
            {
                Console.WriteLine("{0} ({1}/{2}) ({3} points per occurrence, {4} bonus points)", goal.Name, goal.Progress, goal.Target, goal.Value, goal.Value * (goal.Target - 1));
            }
        }
    }

    static void RecordEvent()
    {
        Console.WriteLine("Record an event");
        Console.Write("Goal name: ");
        string name = Console.ReadLine();

        Goal goal = Goals.Find(g => g.Name == name);
        if (goal == null)
        {
            Console.WriteLine("Goal not found");
            return;
        }

        if (goal.Type == GoalType.Simple)
        {
            if (goal.Progress == 0)
            {
                goal.Progress = 1;
                Score += goal.Value;
                Console.WriteLine("Goal completed! Score increased by {0} points", goal.Value);
            }
            else
            {
                Console.WriteLine("Goal already completed");
            }
        }
        else if (goal.Type == GoalType.Eternal)
        {
            goal.Progress++;
            Score += goal.Value;
            Console.WriteLine("Goal progress recorded! Score increased by {0} points", goal.Value);
        }
        else if (goal.Type == GoalType.Checklist)
        {
            if (goal.Progress < goal.Target)
            {
                goal.Progress++;
                Score += goal.Value;
                Console.WriteLine("Goal progress recorded! Score increased by {0} points", goal.Value);
                if (goal.Progress == goal.Target)
                {
                    Score += goal.Value * (goal.Target - 1);
                    Console.WriteLine("Goal completed! Score increased by {0} bonus points", goal.Value * (goal.Target - 1));
                }
            }
            else
            {
                Console.WriteLine("Goal already completed");
            }
        }
    }

    static void AddGoal()
    {
        Console.WriteLine("Add a goal");
        Console.Write("Goal name: ");
        string name = Console.ReadLine();
        Console.Write("Goal value: ");
        int value = int.Parse(Console.ReadLine());
        Console.WriteLine("Goal type");
        Console.WriteLine("1. Simple");
        Console.WriteLine("2. Eternal");
        Console.WriteLine("3. Checklist");
        Console.Write("Choose a type: ");
                int type = int.Parse(Console.ReadLine());
        Goal goal = null;
        if (type == 1)
        {
            Goal goal1 = new Goal(name, value, GoalType.Simple, 0, 0);


        }
        else if (type == 2)
        {
            Goal goal2 = new Goal(name, value, GoalType.Eternal, 0, 0);

        }
        else if (type == 3)
        {
            Console.Write("Goal target: ");
            int target = int.Parse(Console.ReadLine());
            Goal goal3 = new Goal(name, value, GoalType.Checklist, 0, target);

        }
        Goals.Add(goal);
        Console.WriteLine("Goal added");
    }

    static void Save()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(Score);
            writer.WriteLine(Goals.Count);
            foreach (Goal goal in Goals)
            {
                writer.WriteLine(goal.Name);
                writer.WriteLine(goal.Value);
                writer.WriteLine((int)goal.Type);
                writer.WriteLine(goal.Progress);
                if (goal.Type == GoalType.Checklist)
                {
                    writer.WriteLine(goal.Target);
                }
            }
        }
        Console.WriteLine("Data saved");
    }

    // static void Load()
    // {
    //     if (File.Exists("goals.txt"))
    //     {
    //         using (StreamReader reader = new StreamReader("goals.txt"))
    //         {
    //             Score = int.Parse(reader.ReadLine());
    //             int count = int.Parse(reader.ReadLine());
    //             for (int i = 0; i < count; i++)
    //             {
    //                 Goal goal = new Goal
    //                 {
    //                     Name = reader.ReadLine(),
    //                     Value = int.Parse(reader.ReadLine()),
    //                     Type = (GoalType)int.Parse(reader.ReadLine()),
    //                     Progress = int.Parse(reader.ReadLine())
    //                 };
    //                 if (goal.Type == GoalType.Checklist)
    //                 {
    //                     goal.Target = int.Parse(reader.ReadLine());
    //                 }
    //                 Goals.Add(goal);
    //             }
    //         }
    //         Console.WriteLine("Data loaded");
    //     }
    //     else
    //     {
    //         Console.WriteLine("File not found");
    //     }
    // }
}

