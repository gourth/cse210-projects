using System;

class Program
{
    static void Main(string[] args)
    {
        int userMenuInput = 0;

        List<string> menu = new List<string>
        {
            "Menu Options:",
            "   1. Start breathing activity",
            "   2. Start reflecting activity",
            "   3. Start listing activity",
            "   4. Quit"
        };

        while (userMenuInput != 4)
        {
            Console.Clear();
            foreach (string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }
            Console.Write("Select a choice from the menu: ");
            userMenuInput = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (userMenuInput)
            {
                case 1:
                    BreathingActivity bactivity = new BreathingActivity();
                    bactivity.runActivity();
                    break;
                case 2:
                    ReflectingActivity ractivity = new ReflectingActivity();
                    ractivity.runActivity();
                    break;
                
                case 3:
                    ListingActivity activity = new ListingActivity();
                    activity.runActivity();
                    break;

            }
        }
    }
}