using System;
using System.Collections;
using System.Collections.Generic;

namespace Question_5
{
    class Program
    {
        //This method is used to merge the characters of the two strings alternatively
        public string MergeAlternately(string word1, string word2)
        {
            List<String> lst1 = new List<String>();
            List<String> lst2 = new List<String>();
            List<String> lst3 = new List<String>();
            //Converting the characters of the string to a list of String
            for (int i = 0; i < word1.Length; i++)
                lst1.Add(word1[i].ToString());
            //Converting the characters of the string to a list of String
            for (int i = 0; i < word2.Length; i++)
                lst2.Add(word2[i].ToString());
            //Add the characters alternatively if the count of both the strings is the same
            if (lst1.Count == lst2.Count)
            {
                for (int i = 0; i < word1.Length; i++)
                {
                    lst3.Add(lst1[i]);
                    lst3.Add(lst2[i]);
                }
            }
            /*If the length of the strings differ, add the characters alternatively and append the
            remaining characters of the longer string to the end*/
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
            /*If the length of the strings differ, add the characters alternatively and append the
            remaining characters of the longer string to the end*/
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
            //Join the elements of the list to a String using the String.Join method
            return(String.Join("", lst3));
        }

        static void Main(string[] args)
        {
            //Taking the input word1
            Console.Write("Please enter the first word: ");
            string word1 = Console.ReadLine();
            //Taking the input word2
            Console.Write("Please enter the second word: ");
            string word2 = Console.ReadLine();
            Program P = new Program();
            //Calling the MergeAlternately method
            String result = P.MergeAlternately(word1,word2);
            Console.Write("The alternatively merged string is: ");
            Console.Write(result);
            Console.Read();
        }
    }
}

