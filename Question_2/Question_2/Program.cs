using System;

namespace Question_2
{
    class Program
    {
        public bool CheckIfPangram(string inpt)
        {
            string str = "abcdefghijklmnopqrstuvwxyz";
            bool x = false;
            foreach (char i in str.ToLower())
            {
                if (inpt.IndexOf(i) == -1)
                {
                    x = false;
                    break;
                }
                else
                {
                    x = true;
                }
            }
            return x;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the input");
            string inpt = Console.ReadLine();
            bool y;
            Program P = new Program();
            y = P.CheckIfPangram(inpt);
            Console.WriteLine(y);
            Console.ReadLine();
        }
    }
}
