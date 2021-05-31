using System;

namespace Question_1
{
    class Program
    {
        static public bool JudgeCircle(string moves)
        {
            int x = 0;
            int y = 0;
            char[] moves_array = moves.ToCharArray();
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
                Console.WriteLine(x);
                Console.WriteLine(y);
            }
            
            return (x == 0 && y == 0);
        }
        static void Main(string[] args)
        {
            Console.Write("Please enter the moves: ");
            string steps = Console.ReadLine();
            bool result = Program.JudgeCircle(steps);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
