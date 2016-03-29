using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using AWA.Poker;

namespace problem54_VS
{
    /// <summary>
    /// This program counts the number of time player 1 wins
    /// by comparing the poker hands found in each line of the
    /// provided file.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("p054_poker.txt");
            int wins = 0;
            foreach(var line in lines)
            {
                wins += Play(line);
            }
            Console.WriteLine(wins.ToString());
            Console.ReadLine();
        }

        public static int Play(string line)
        {
            string p1Hand = new string(line.Take(14).ToArray());
            string p2Hand = new string(line.Skip(15).ToArray());
            var h1 = new Hand(p1Hand);
            var h2 = new Hand(p2Hand);
            int val = h1.CompareTo(h2);
            string result = "LOSS";
            if (val > 0) result = "WIN";
            if (val == 0)
            {
                result = "**TIE**";
            }
            Console.WriteLine("P1={0}  P2={1}  {2}", h1, h2, result);
            if (val > 0) return 1;
            return 0;
        }
    }
}
