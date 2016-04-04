using System;
using System.Collections.Generic;
using System.Linq;

namespace Monopoly
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Adam Adair's Monopoly Simulator!");
            Console.Write("\nSimulating...");
            try {
                Monopoly m = new Monopoly(4);
                m.Simulate(100000000);
                Console.WriteLine("Complete!");
                Square[] squares = m.GetBoard();
                foreach (var s in squares)
                {
                    Console.WriteLine("{0}[{1}] = {2}", s.Name, s.Id, s.Visits);
                }
                Console.WriteLine("\n\n");
                foreach (var s in squares.OrderByDescending(c => c.Visits).Take(3))
                {
                    Console.Write(s.Id);
                }
                Console.WriteLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            Console.ReadLine();
        }
    }
}
