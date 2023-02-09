using System;

class Program
{
    static void Main(string[] args)
    {
        AllGoals allGoals = new AllGoals();
        int userMainMenuSelection = 0;

        while (userMainMenuSelection != 6)
        {
            Menu menu = new Menu();
            menu.DisplayPoints(allGoals.getTotalPoints());
            menu.DisplayMainMenu();
            userMainMenuSelection = menu.DisplayGetMainMenu();

            switch (userMainMenuSelection)
            {
                case 1:
                    int createNewGoalSelection = menu.DisplayGetCreateNewGoalMenu();
                    Goal goal = null;
                    switch (createNewGoalSelection)
                    {
                        case 1:
                            goal = new SimpleGoal();
                            goal.DisplayGetGoalName();
                            goal.DisplayGetGoalDescription();
                            goal.DisplayGetGoalPoints();
                            break;
                    }
                    if (goal != null)
                    {
                        allGoals.addGoal(goal);
                    }

                    break;
                case 2:
                    allGoals.DisplayGoals();
                    break;
                case 3: 
                    allGoals.SaveGoals();
                    break;
                case 4:
                    allGoals.LoadGoals();
                    break;
            }
        }
    }
}