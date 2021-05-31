using System;

namespace Question_4
{
    class Program
    {
        public int PivotIndex(int[] lst)
        {
            int result = -1;
            for (int i = 0; i < lst.Length; i++)
            {
                int suml = 0;
                int sumr = 0;
                if (i == 0)
                {
                    suml = 0;
                    for (int j = i + 1; j < lst.Length; j++)
                    {
                        sumr = sumr + lst[j];
                    }
                }
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
            Console.Write("Please enter the list of numbers seperated by a comma: ");
            string strlst = (Console.ReadLine());
            string[] strlist = strlst.Split(',');
            int[] lst = new int[strlist.Length];
            for (int i = 0; i < strlist.Length; i++)
            {
                lst[i] = (int.Parse(strlist[i]));
            }
            Program P = new Program();
            int result = P.PivotIndex(lst);
            Console.Write("The pivot index is: ");
            Console.Write(result);
            Console.Read();
        }
    }
}
