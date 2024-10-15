using System;


namespace PrimeNumber_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int number, flag = 0, i;
            Console.WriteLine("Please enter a number : ");
            number = Convert.ToInt32(Console.ReadLine());

            for ( i = 2; i <= number; i++)
            {
                if (number % i == 0)
                {
                    flag = 1;
                    i++;
                }
                else
                {
                    flag = 0;
                    i++;
                    
                }
               
            }
            if (flag == 0)
            {
                Console.WriteLine("Yes, {0} is a prime number ", number);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No, {0} is not a prime number ", number);
                Console.ReadKey();
            }


        }
    }
}