using System;


namespace ArmstrongNumber_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            int number, temp,sum=0,rem;
            Console.WriteLine("Please enter a number : ");
            number = Convert.ToInt32(Console.ReadLine());
            temp=number;
          
            while (number != 0)
            {
                rem = number % 10;
                sum = sum + (rem * rem * rem);
                number /= 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("Yes, {0} is an Armstrong Number .",temp);
            }
            else
            {
                Console.WriteLine("No, {0} is not an Armstrong Number ..",temp);
            }
        }
    }
}
