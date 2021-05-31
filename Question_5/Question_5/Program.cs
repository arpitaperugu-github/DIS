using System;
using System.Collections;
using System.Collections.Generic;

namespace Question_5
{
    class Program
    {
        public string MergeAlternately(string word1, string word2)
        {
            List<String> lst1 = new List<String>();
            List<String> lst2 = new List<String>();
            List<String> lst3 = new List<String>();
            for (int i = 0; i < word1.Length; i++)
                lst1.Add(word1[i].ToString());
            for (int i = 0; i < word2.Length; i++)
                lst2.Add(word2[i].ToString());
            if (lst1.Count == lst2.Count)
            {
                for (int i = 0; i < word1.Length; i++)
                {
                    lst3.Add(lst1[i]);
                    lst3.Add(lst2[i]);
                }
            }
            else if (lst1.Count > lst2.Count)
            {
                for (int i = 0; i < word2.Length; i++)
                {
                    lst3.Add(lst1[i]);
                    lst3.Add(lst2[i]);
                }
                for (int j = word2.Length; j < word1.Length; j++)
                    lst3.Add(lst1[j]);
            }
            else if (lst1.Count < lst2.Count)
            {
                for (int i = 0; i < word1.Length; i++)
                {
                    lst3.Add(lst1[i]);
                    lst3.Add(lst2[i]);
                }
                for (int j = word1.Length; j < word2.Length; j++)
                    lst3.Add(lst2[j]);
            }
            return(String.Join("", lst3));
        }

        static void Main(string[] args)
        {
            Console.Write("Please enter the first word: ");
            string word1 = Console.ReadLine();
            Console.Write("Please enter the second word: ");
            string word2 = Console.ReadLine();
            Program P = new Program();
            String result = P.MergeAlternately(word1,word2);
            Console.Write("The alternatively merged string is: ");
            Console.Write(result);
            Console.Read();
        }
    }
}

