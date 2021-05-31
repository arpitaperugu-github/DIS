using System;


namespace Question_3
{
    class Program
    {
        public int NumIdenticalPairs(int[] lst)
        {
            int count = 0;
            for (int i = 0; i < lst.Length; i++)
            {
                for (int j = 0; j < lst.Length; j++)
                {
                    if (i < j)
                    {
                        if (lst[i] == lst[j])
                        {
                            count = count + 1;
                        }
                    }
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.Write("Please enter the list of numbers seperated by a comma: ");
            string strlst = (Console.ReadLine());
            string[] strlist = strlst.Split(',');
            int[] lst = new int[strlist.Length];
            for(int i=0;i<strlist.Length;i++)
            {
                lst[i]=(int.Parse(strlist[i]));
            }
            Program P = new Program();
            int count = P.NumIdenticalPairs(lst);
            Console.Write("Count of Identical Numeric Pairs are: ");
            Console.Write(count);
            Console.Read();
            
        }
    }
}
