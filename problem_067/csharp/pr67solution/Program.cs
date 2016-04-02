using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr18solution
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = new Triangle("p067_triangle.txt");
            int max = t.GetMaxTotal();
            Console.WriteLine("Max Value = {0}", max);
            Console.ReadLine();
        }
    }
}
