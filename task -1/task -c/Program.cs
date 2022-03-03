using System;

namespace task__c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            if (number%2==0)
            {
                Console.WriteLine("cut ededdir");
            }
            else if(number%2==1)
            {
                Console.WriteLine("tek ededdir");
            }
        }
    }
}
