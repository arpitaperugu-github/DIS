using System;

namespace Question_4
{
    class Program
    {
        /*This method is used to return the index where the sum of all the numbers strictly to the left
        of the index is equal to the sum of all the numbers strictly to the index's right.*/
        public int PivotIndex(int[] lst)
        {
            int result = -1;
            for (int i = 0; i < lst.Length; i++)
            {
                int suml = 0;
                int sumr = 0;
                //If we are at the leftmost index then the sum to the left is zero and the sum to the right is computed
                if (i == 0)
                {
                    suml = 0;
                    for (int j = i + 1; j < lst.Length; j++)
                    {
                        sumr = sumr + lst[j];
                    }
                }
                //If we are at the rightmost index then the sum to the right is zero and the sum to the left is computed
                else if (i == (lst.Length) - 1)
                {
                    sumr = 0;
                    for (int j = 0; j < ((lst.Length) - 1); j++)
                    {
                        suml = suml + lst[j];
                    }
                }
                else
                {
                    for (int j = 0; j < i; j++)
                    {
                        suml = suml + lst[j];
                    }
                    for (int j = i + 1; j < lst.Length; j++)
                    {
                        sumr = sumr + lst[j];
                    }
                }
                //If the sum to the left is same as sum to the right then we will return that index value else return -1
                if (suml == sumr)
                {
                    result = i;
                }
            }
            if (result == -1)
            {
                return -1;
            }
            else
            {
                return result;
            }
        }
        static void Main(string[] args)
        {
            //Taking the input from the user
            Console.Write("Please enter the list of numbers seperated by a comma: ");
            string strlst = (Console.ReadLine());
            //Splitting the input to an array of String
            string[] strlist = strlst.Split(',');
            int[] lst = new int[strlist.Length];
            //Converting the array of String to array of integer
            for (int i = 0; i < strlist.Length; i++)
            {
                lst[i] = (int.Parse(strlist[i]));
            }
            Program P = new Program();
            //Calling the method PivotIndex
            int result = P.PivotIndex(lst);
            Console.Write("The pivot index is: ");
            Console.Write(result);
            Console.Read();
        }
    }
}
