using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Question_6
{
    class Program
    {
        public static string ToGoatLatin(string sentence)
        {
            string[] str = sentence.Split(" ");
            string mystring = "aeiouAEIOU";
            for (int i = 0; i < str.Length; i++)
            {
                if (mystring.Contains((str[i][0].ToString())))
                {
                    str[i] = str[i] + "ma";
                }
                else
                {
                    str[i] = str[i][1..] + str[i][0] + "ma";
                }
            }
            for (int i = 0; i < str.Length; i++)
            {
                str[i] = str[i] + String.Join("", Enumerable.Repeat("a", (i + 1)));
            }
            return(String.Join(" ", str));
        }
        static void Main(string[] args)
        {
            Console.Write("Please enter the sentence: ");
            string sentence = Console.ReadLine();
            Console.Write("The GoatLatin sentence is: ");
            Console.Write(Program.ToGoatLatin(sentence));
            Console.ReadLine();
        }
    }
}
