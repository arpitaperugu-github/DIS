using System;

namespace Question_2
{
    class Program
    {
        //CheckIfPangram is a method that returns true if a input string is a Pangram else returns false
        public bool CheckIfPangram(string inpt)
        {
            string str = "abcdefghijklmnopqrstuvwxyz";
            bool x = false;
            //Checks if each character of str is present in the input
            foreach (char i in str.ToLower())
            {
                //If each character of str is not present in the input string then the loop breaks and the method returns false
                if (inpt.IndexOf(i) == -1)
                {
                    x = false;
                    break;
                }
                //If each character of str is present in the input string then the method returns true.
                else
                {
                    x = true;
                }
            }
            return x;
        }
        static void Main(string[] args)
        {
            //Taking the input from the user
            Console.WriteLine("Please enter the input");
            string inpt = Console.ReadLine();
            bool y;
            Program P = new Program();
            //Calling the CheckIfPangram method
            y = P.CheckIfPangram(inpt);
            Console.WriteLine(y);
            Console.ReadLine();
        }
    }
}
