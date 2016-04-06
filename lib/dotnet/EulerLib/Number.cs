using System;

namespace EulerLib
{
    /// <summary>
    /// A collection of useful methods for Numbers. Most of these have been
    /// added because they have been used over and over again in the Project
    /// Euler problems, so rather than copy and pasting the same code over 
    /// and over I just moved them here for convenience. 
    /// </summary>
    public class Number
    {
        /// <summary>
        /// Determines if n is a prime number.
        /// </summary>
        /// <param name="n">The number to check</param>
        /// <returns>True if n is prime, otherwise false</returns>
        public static bool IsPrime(int n)
        {
            if (n % 1 > 0 || n < 2) return false; // Quick check for invalid prime check
            if (n == LeastFactor(n)) return true; // If n is its own least factor, it must be prime
            return false; 
        }

        /// <summary>
        /// Determines if n is a perfect square.
        /// </summary>
        /// <param name="n">the number to check</param>
        /// <returns>True if n is square, otherwise false</returns>
        public static bool IsSquare(int n)
        {
            double result = Math.Sqrt(n);
            return result % 1 == 0;
        }
        
        /// <summary>
        /// Returns the smallest prime that divides n
        /// </summary>
        /// <param name="n">n is the number</param>
        /// <returns>The smallest prime that divides n</returns>
        public static int LeastFactor(int n)
        {
            if (n == 0) return 0;
            if (n % 1 > 0) return 1;
            if (n % 2 == 0) return 2;
            if (n % 3 == 0) return 3;
            if (n % 5 == 0) return 5;
            int m = Convert.ToInt32(Math.Sqrt(n));
            int i = 7;
            while (i <= m)
            {
                if (n % i == 0) return i;
                if (n % (i + 4) == 0) return i + 4;
                if (n % (i + 6) == 0) return i + 6;
                if (n % (i + 10) == 0) return i + 10;
                if (n % (i + 12) == 0) return i + 12;
                if (n % (i + 16) == 0) return i + 16;
                if (n % (i + 22) == 0) return i + 22;
                if (n % (i + 24) == 0) return i + 24;
                i += 30;
            }
            return n;
        }

        /// <summary>
        /// Determines if a number as a palindrom for a given number base.
        /// <code>
        /// IsPalindrome(545, 10) => true
        /// IsPalindrome(654, 10) => false
        /// </code>
        /// </summary>
        /// <param name="n">The number</param>
        /// <param name="b">The base</param>
        /// <returns></returns>
        public static bool IsPalindrome(int n, int b)
        {
            int reversed = 0;
            int k = n;
            while (k > 0) {
                reversed = b * reversed + k % b;
                k = k / b;
            }
            return (n == reversed);
        }
    }

    /// <summary>
    /// Convenience entensions added to int.
    /// </summary>
    public static class IntExtensions
    {
        public static bool IsPrime(this int value)
        {
            return Number.IsPrime(value);            
        }

        public static bool IsSquare(this int value)
        {
            return Number.IsSquare(value);
        }
    }
}
