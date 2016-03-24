using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EulerLib;

namespace Problem49_VS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetAnswer());
            Console.ReadLine();
        }

        static string GetAnswer()
        {
            // Make a list of 4 digit primes larger than 1487
            List<int> Primes = new List<int>();
            for (int i = 1489; i < 10000; i += 2)
                if (i.IsPrime())
                    Primes.Add(i);

            foreach (var a in Primes)
            {
                Console.WriteLine(a);
                foreach(var b in Primes.Where(p => p > a))
                {
                    foreach(var c in Primes.Where(p2=> p2 > b))
                    {
                        if (c - b == b - a)// The difference between a and b needs to match the diff from b to c
                        {

                            var aStr = SortDigits(a);
                            var bStr = SortDigits(b);
                            var cStr = SortDigits(c);
                            if (
                                aStr.Equals(bStr) &&    // a, b, c must have the same digits.
                                bStr.Equals(cStr) &&
                                cStr.Equals(aStr))
                            {
                                return string.Format("{0}{1}{2}", a.ToString(), b.ToString(), c.ToString());
                            }
                        }
                    }
                }                
            }
            return "FAIL!";
        }

        static string SortDigits(int i)
        {
            var ca = i.ToString().ToCharArray();
            Array.Sort(ca);
            return new string(ca);
        }
       

    }
}
