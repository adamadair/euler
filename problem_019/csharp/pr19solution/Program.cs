using System;

namespace pr19solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for(int year=1901; year <=2000; ++year)
            {
                for(int month = 1; month <= 12; ++month)
                {
                    if (new DateTime(year, month, 1).DayOfWeek == DayOfWeek.Sunday)
                        ++count;
                }
            }
            Console.WriteLine(count.ToString());
            Console.ReadLine();
        }
    }
}
