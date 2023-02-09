using System;
using System.Collections.Generic;
using System.IO;

namespace GoalTracker
{
    class Goal
    {
        public string Name { get; set; }
        public int Type { get; set; }
        public int Progress { get; set; }
        public int Target { get; set; }
        public int Value { get; set; }
        public bool IsComplete { get; set; }

        public Goal(string name, int type, int progress, int target, int value, bool isComplete)
        {
            Name = name;
            Type = type;
            Progress = progress;
            Target = target;
            Value = value;
            IsComplete = isComplete;
        }
    }

    class Program
    {
        static int score = 0;
        static List<Goal> goals = new List<Goal>();

        static void Main(string[] args)
        {
            Console.WriteLine("Goal Tracker\n");
            LoadGoals();
            DisplayMenu();
        }

        static void DisplayMenu()
        {
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. Record an event");
            Console.WriteLine("3. Display goals");
            Console.WriteLine("4. Display score");
            Console.WriteLine("5. Exit\n");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    RecordEvent();
                    break;
                case 3:
                    DisplayGoals();
                    break;
                case 4:
                    DisplayScore();
                    break;
                case 5:
                    SaveGoals();
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.\n");
                    DisplayMenu();
                    break;
            }
        }

        static void CreateGoal()
        {
            Console.Write("Enter goal name: ");
            string name = Console.ReadLine();

            Console.WriteLine("\nGoal type:");
            Console.WriteLine("1. Simple goal");
            Console.WriteLine("2. Eternal goal");
            Console.WriteLine("3. Checklist goal\n");

            Console.Write("Enter goal type: ");
            int type = int.Parse(Console.ReadLine());

            Console.Write("Enter goal value: ");
            int value = int.Parse(Console.ReadLine());

            int target = 0;
            if (type == 3)
            {
                Console.Write("Enter target: ");
                target = int.Parse(Console.ReadLine());
            }

            goals.Add(new Goal(name, type, 0, target, value, false));
            Console.WriteLine("Goal created successfully.\n");
            DisplayMenu();
        }

        static void RecordEvent()
        {
            Console.WriteLine("\nGoals:");
            for (int i = 0; i < goals.Count; i++)
            {
                 Console.WriteLine((i + 1) + ". " + goals[i].Name + " (" + goals[i].Progress + "/" + goals[i].Target + ")");
            }
            

            Console.Write("\nEnter the goal number to record event: ");
            int goalNumber = int.Parse(Console.ReadLine());
            Goal selectedGoal = goals[goalNumber - 1];

            selectedGoal.Progress++;
            score += selectedGoal.Value;

            if (selectedGoal.Type == 1 && selectedGoal.Progress >= 1)
            {
                selectedGoal.IsComplete = true;
                Console.WriteLine("Goal completed. You earned " + selectedGoal.Value + " points.\n");
            }
            else if (selectedGoal.Type == 2)
            {
                Console.WriteLine("Event recorded. You earned " + selectedGoal.Value + " points.\n");
            }
            else if (selectedGoal.Type == 3 && selectedGoal.Progress == selectedGoal.Target)
            {
                selectedGoal.IsComplete = true;
                score += selectedGoal.Value;
                Console.WriteLine("Goal completed. You earned " + (selectedGoal.Value * 2) + " points.\n");
            }
            else if (selectedGoal.Type == 3)
            {
                Console.WriteLine("Event recorded. You earned " + selectedGoal.Value + " points.\n");
            }

            DisplayMenu();
        }

        static void DisplayGoals()
        {
            Console.WriteLine("\nGoals:");
            for (int i = 0; i < goals.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + goals[i].Name + " (" + goals[i].Progress + "/" + goals[i].Target + ")");
            }
            Console.WriteLine();
            DisplayMenu();
        }

        static void DisplayScore()
        {
            Console.WriteLine("\nScore: " + score + "\n");
            DisplayMenu();
        }

        static void LoadGoals()
        {
            if (File.Exists("goals.txt"))
            {
                string[] lines = File.ReadAllLines("goals.txt");
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    goals.Add(new Goal(parts[0], int.Parse(parts[1]), int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4]), bool.Parse(parts[5])));
                }
            }
        }

        static void SaveGoals()
        {
            List<string> lines = new List<string>();
            foreach (Goal goal in goals)
            {
                lines.Add(goal.Name + "," + goal.Type + "," + goal.Progress + "," + goal.Target + "," + goal.Value + "," + goal.IsComplete);
            }
            File.WriteAllLines("goals.txt", lines);
        }
    }
}
