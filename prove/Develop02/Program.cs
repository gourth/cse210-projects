using System;
using System.IO;
using System.Text;

class Program
{

    string filePath = "C:\\temp\\CSVTest.csv";
    static void Main(string[] args)
    {
        Program program = new Program();

        program.writeToCSV();
        program.readFromCSV();
    }

    public void writeToCSV()

    // Write CSV file
    StringBuilder builder = new StringBuilder();

    string text1 = "Text1";
    string text2 = "Text2";
    Builder.AppendLine(string.Format("{0}|{1}", text1, text2));

    File.WrtieAllText(filePath, UriBuilder.ToString());

    public void readFromCSV()
    {
        StreamReader streamReader = new StreamReader(filePath);

        while (!streamReader.EndOfStream)
        {
            var line = streamReader.ReadLine();
            var values = line.Split();

            Console.WriteLine("{0}|{1}", values[0], values[1]);
        }
    }


}