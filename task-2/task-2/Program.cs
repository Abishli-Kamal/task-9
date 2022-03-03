using System;

namespace task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1>num2)
            {
                Console.WriteLine("num1 boyukdur");
            }
            else if(num1<num2)
            {
                Console.WriteLine("num2 boyukdur");
            }
            else
            {
                Console.WriteLine("beraberdir");
            }
        }
    }
}
