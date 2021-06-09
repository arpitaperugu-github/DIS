using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Question_6
{
    class Program
    {
        //This method is used to convert a sentence to Goat Latin
        public static string ToGoatLatin(string sentence)
        {
            //Converting the words of the string input to an array of strings using the Split method
            string[] str = sentence.Split(" ");
            string mystring = "aeiouAEIOU";
            for (int i = 0; i < str.Length; i++)
            {
                //Checking if the first character of the word is a vowel
                if (mystring.Contains((str[i][0].ToString())))
                {
                    //If the word starts with vowel we append 'ma' to the end of the word
                    str[i] = str[i] + "ma";
                }
                //If a word begins with a consonant, remove the first letter and append it to the end, then add "ma".
                else
                {
                    str[i] = str[i][1..] + str[i][0] + "ma";
                }
            }
            //To add one letter 'a' to the end of each word per its word index in the sentence, starting with 1.
            for (int i = 0; i < str.Length; i++)
            {
                str[i] = str[i] + String.Join("", Enumerable.Repeat("a", (i + 1)));
            }
            return(String.Join(" ", str));
        }
        static void Main(string[] args)
        {
            //Taking the input sentence from the user
            Console.Write("Please enter the sentence: ");
            string sentence = Console.ReadLine();
            Console.Write("The GoatLatin sentence is: ");
            //Calling the ToGoatLatin method
            Console.Write(Program.ToGoatLatin(sentence));
            Console.ReadLine();
        }
    }
}
