using System;

namespace ConsoleApp15
{
    public class Program
    {
        static void Main(string[] args)
        {
            Time time1 = new Time(10, 30, 45);
            Time time2 = new Time(4, 15, 20);

            Time sum = time1 + time2;
            Time difference = time1 - time2;

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Difference: " + difference);

            Console.WriteLine("Time1 > Time2: " + (time1 > time2));
            Console.WriteLine("Time1 < Time2: " + (time1 < time2));

            Time incremented = ++time1;
            Time decremented = --time1;

            Console.WriteLine("Incremented: " + incremented);
            Console.WriteLine("Decremented: " + decremented);

            Console.ReadLine();
        }
    }
}