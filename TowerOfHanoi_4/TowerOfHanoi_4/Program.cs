using System;

namespace TowerOfHanoi_4
{
    public class Program
    {
        public static void Main(String[] args)
        {
            int n = 3;
            String from = "A";
            String to = "B";
            String via = "C";
            hanoi(n, from, via, to);
        }
        public static void hanoi(int n, String from, String to, String via)
        {
            if (n == 1)
            {
                Console.WriteLine("Move disk 1 from " + from + " to " + to);
            }
            else
            {
                hanoi(n - 1, from, via, to);
                Console.WriteLine("Move disk " + n + " from " + from + " to " + to);
                hanoi(n - 1, via, to, from);
            }
        }


    }
}
