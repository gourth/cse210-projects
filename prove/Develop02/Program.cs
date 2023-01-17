using System;
using System.IO;
using System.Text;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {

    Journal j = new Journal();

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
    
        int choice = int.Parse(c);
        return choice;
    }
    void displayMenu()
    {
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
    }

    int choice = 0;

    while (choice != 5)
    {
        journalEntry e = new journalEntry();

        displayMenu();
        choice = getChoice();

        if (choice == 1)
        {
            string date = DateTime.Now.ToString("M/d/yyy");
            // e._date = DateOnly;
            

            int prom = e.getEntryPrompt();
            string p0 = "What cute thing did your daugther do today? ";
            string p1 = "What did you eat for dinner? ";
            string p2 = "Who did you help today? ";
            string p3 = "What was blessing did you receive today? ";
            string p4 = "How did you feel today? ";

            if (prom == 0)
            {
                e._prompt = p0;
            }

            else if (prom == 1)
            {
                e._prompt = p1;
            }

            else if (prom == 2)
            {
                e._prompt = p2;
            }

            else if (prom == 3)
            {
                e._prompt = p3;
            }

            else if (prom == 4)
            {
                e._prompt = p4;
            }

            Console.WriteLine(e._prompt);
            Console.Write("Write your entry: ");
            e._entry = Console.ReadLine();
            // journalEntry._AllEntries.Add(e);


        }

        else if (choice ==2)
        {
            foreach(journalEntry line in j._AllEntries)
        
        {
            Console.WriteLine(line._date);
            Console.WriteLine(line._prompt);
            Console.WriteLine(line._entry);
        }
        }

        else if (choice ==3)
        {
            Console.Write("Enter your file name: ");
            string filename = Console.ReadLine();
            string[] lines = System.IO.File.ReadAllLines(filename);
            int arrLen = lines.Length;
            Console.WriteLine(arrLen);
            foreach(string line in lines)
            {
                Console.WriteLine("Thi is the array");
                Console.WriteLine(line);
            }

            Console.WriteLine("");

            for (int count = 0; count <arrLen; count +=3)
            {
                e._date = lines[count];
                e._prompt = lines[count+1];
                e._prompt = lines[count+2];
                j._AllEntries.Add(e);
            }
            foreach(journalEntry line in j._AllEntries)
            {
                Console.WriteLine(line._date);
                Console.WriteLine(line._prompt);
                Console.WriteLine(line._entry);
            }
        }

        else if (choice == 4)
        {
            Console.Write("Please enter filename: ");
            string filelocation = Console.ReadLine();
            using (StreamWriter writer = new StreamWriter(filelocation))
            {
                foreach(journalEntry line in j._AllEntries)
                {
                    writer.WriteLine($"Date: {line._date}");
                    writer.WriteLine($"Date: {line._prompt}");
                    writer.WriteLine($"Date: {line._entry}");
                }
            }
        }

    
    }


}
}