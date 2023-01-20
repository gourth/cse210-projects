using System;

class scriptureMemorizer
{
    private Scripture scripture;
    private List<string> scriptureTextList;

    public scriptureMemorizer(Scripture _scripture)
    {
        scripture = _scripture;
        scriptureTextList = new List<string>();
        convertTextToList();
    }

    private void convertTextToList()
    {
        scriptureTextList = scripture.toString().Split(' ').ToList();
    }

    public void removeWordsFromText()
    {
        int numWordsToRemove = new Random().Next(2, 4);
        int wordsRemoved = 0;

        do
        {
            int rndIndex = new Random().Next(0, scriptureTextList.Count());
            scriptureTextList[rndIndex] = new string('_', scriptureTextList[rndIndex].Length);
            wordsRemoved++;
        } while (wordsRemoved != numWordsToRemove);
        
    }

    public string toString()
    {
        return string.Join(' ', scriptureTextList);
    }

    public bool hasWordsLeft()
    {
        bool retvalue = false;

        foreach (string word in scriptureTextList)
        {
            if (word.Contains('_') == false)
            {
                retvalue = true;
                break;
            }
        }

        return retvalue;
    }
}