using System;

namespace Question_1
{
    class Program
    {
        //Given a sequence of its moves this method judges if the robot ends up at(0, 0) after it completes its moves
        static public bool JudgeCircle(string moves)
        {
            int x = 0;
            int y = 0;
            //Converting the input string to an array of characters
            char[] moves_array = moves.ToCharArray();
            //Loop over the array of characters and increment/decrement the x and y coordinates accordingly
            for (int i = 0; i < moves_array.Length; i++)
            {
                if (moves_array[i] == 'R' || moves_array[i] == 'r')
                    x++;
                else if (moves_array[i] == 'L' || moves_array[i] == 'l')
                    x--;
                else if (moves_array[i] == 'U' || moves_array[i] == 'u')
                    y++;
                else if (moves_array[i] == 'D' || moves_array[i] == 'd')
                    y--;
            }
            //Returns true of x and y is equal to zero else returns false
            return (x == 0 && y == 0);
        }
        static void Main(string[] args)
        {
            //Taking the input from the user
            Console.Write("Please enter the moves: ");
            string steps = Console.ReadLine();
            //Calling the JudgeCircle function
            bool result = Program.JudgeCircle(steps);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
