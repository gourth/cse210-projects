using System;
using System.IO;
using System.Text;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)

    int getChoice()
    {
        Console.Write("What will you do?: ");
        string c = Console.ReadLine();
        if (c != "1" && c != "2" && c != "3" && c != "4" && c!= "4" && c!= "5")
        {
            while(c != "1" && c != "2" && c != "3" && c != "4" && c!= "4" && c!= "5")
            {
                Console.WriteLine("Invaid choice.(must be a number from 1-5)");
                Console.WriteLine("What will you do?: ");
                c = Console.ReadLine();
            }
        }
    }
        int choice = int.Parse(c);
        return choice

    void displayMenu()
    {
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
    }
}
