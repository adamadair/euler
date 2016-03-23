using System;
using EulerLib;

namespace Problem36_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = 1000000;
            int sum = 0;
            int i = 1;
            int p = MakePalindrome(i, 2, true);
            while (p < limit)
            {
                if (Number.IsPalindrome(p, 10))
                    sum += p;
                ++i;
                p = MakePalindrome(i, 2, true);
            }
            i = 1;
            p = MakePalindrome(i, 2, false);
            while (p < limit)
            {
                if (Number.IsPalindrome(p, 10))
                    sum += p;
                ++i;
                p = MakePalindrome(i, 2, false);
            }
            Console.WriteLine(sum.ToString());
            Console.ReadLine();
        }

        static int MakePalindrome(int n, int b, bool oddLength)
        {
            int res = n;
            if (oddLength)
                n /= b;
            while (n > 0)
            {
                res = b * res + n % b;
                n /= b;
            }
            return res;
        }
    }
}
