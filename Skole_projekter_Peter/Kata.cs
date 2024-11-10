using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Kata
{

    static int Main(string[] args)
    {
        TitleCase("a clash of KINGS", "a an the of");


        return 0;
    }

    public static string TitleCase(string title, string minorWords = "")
    {

        string[] exceptions = minorWords.ToLower().Split("");
        string[] title_words = title.ToLower().Split(" ");

        StringBuilder sb = new StringBuilder();

        foreach (string word in title_words)
        {
            foreach (string exception in exceptions)
            {
                Console.WriteLine(exception);
                if (exception == word)
                {
                    sb.Append(word);
                }

                else
                {

                    for (int i = 0; i < word.Length; i++)
                    {
                        if (i == 0)
                        {
                            sb.Append(char.ToUpper(word[0]));
                        }

                        else
                        {
                            sb.Append(word[i]);
                        }

                    }

                }
            }

            sb.Append(" ");

        }

        sb.Remove(sb.Length -1, 1);
    return sb.ToString();
    }
}



