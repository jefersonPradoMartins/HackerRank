using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        List<string> words = new List<string>();
        
        string line;
        while (!String.IsNullOrWhiteSpace(line = Console.ReadLine()))
        {
            words.Add(line); 
        }


        var result  = camelCase(words);

        foreach (string word in result)
        {
            Console.WriteLine(word);
        }


    }

    public static List<string> camelCase(List<string> wordsList)
    {
        var result = new List<string>();
        foreach( string wordl in wordsList )
        {
       
       var words = wordl.Replace("(", "").Replace(")", "");

        var newWord = words.Split(";");
        var cmd1 = newWord[0];
        var cmd2 = newWord[1];
        var word = newWord[2].ToArray();
        var wordString = newWord[2].ToString();

        if (cmd1.ToUpper() == "S")
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i].ToString() == word[i].ToString().ToUpper() && i > 0)
                {
                    wordString = wordString.Insert(i, " ");
                    word = wordString.ToArray();
                    i++;
                }
            }

            wordString = wordString.ToLower();
        }
        else if (cmd1.ToUpper() == "C")
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i].ToString() == " ")
                {

                    wordString = wordString.Replace(" " + word[i + 1].ToString(), word[i + 1].ToString().ToUpper());
                    word = wordString.ToArray();
                }

            }

            if (cmd2.ToUpper() == "M")
            {
                wordString = wordString + "()";
            }
            else if (cmd2.ToUpper() == "C")
            {


                wordString = wordString[0].ToString().ToUpper() + wordString.Substring(1);
                
            }
        }
         result.Add(wordString);
        }
        return result;
    }
}