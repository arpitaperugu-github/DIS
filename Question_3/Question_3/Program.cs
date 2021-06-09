using System;


namespace Question_3
{
    class Program
    {
        //This method is used to return the number of identical pairs in a list
        public int NumIdenticalPairs(int[] lst)
        {
            int count = 0;
            //Loop over the list of elements and return the number of good pairs 
            for (int i = 0; i < lst.Length; i++)
            {
                for (int j = 0; j < lst.Length; j++)
                {
                    //Check if the index i is less than the index j
                    if (i < j)
                    {
                        //Increment the counter if it is a good pair
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
            //Taking the input from the user
            Console.Write("Please enter the list of numbers seperated by a comma: ");
            string strlst = (Console.ReadLine());
            //Splitting the input string into an array of String
            string[] strlist = strlst.Split(',');
            //Converting the array of String to Array of integers
            int[] lst = new int[strlist.Length];
            for(int i=0;i<strlist.Length;i++)
            {
                lst[i]=(int.Parse(strlist[i]));
            }
            Program P = new Program();
            //Calling the function NumIdenticalPairs
            int count = P.NumIdenticalPairs(lst);
            Console.Write("Count of Identical Numeric Pairs are: ");
            Console.Write(count);
            Console.Read();
            
        }
    }
}
