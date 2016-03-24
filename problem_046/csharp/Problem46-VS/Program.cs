using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EulerLib;

namespace Problem46_VS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Building double square list");
            List<long> DoubleSquares = new List<long>();
            for(long i = 1; i< 1000000; ++i)
            {
                DoubleSquares.Add(2 * (i * i));
            }
            long lastLong = 7L;
            bool conjecture = true;
            long[] ds = DoubleSquares.ToArray();
            DoubleSquares.Clear(); DoubleSquares = null;
            Console.WriteLine("Searching...");
            do
            {
                lastLong += 2;
                conjecture = false; // Assume false, prove true
                if (!lastLong.IsPrime())
                {
                    // lastLong is composite
                    int index = 0;
                    do
                    {
                        if ((lastLong - ds[index]).IsPrime())
                        {
                            conjecture = true;
                        }
                        ++index;
                    } while (index < ds.Length && !conjecture);
                }
                else
                {
                    conjecture = true;
                }
            } while (conjecture);
            Console.WriteLine(lastLong.ToString());
            Console.ReadLine();
        }
    }
}
