using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using EulerLib;

namespace problem_098
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Loading words from file...");
            string[] WordList = LoadWordsFromFile();
            Console.WriteLine("loaded {0} words.", WordList.Length);

            AnagramFinder anagramFinder = new AnagramFinder();
            Console.Write("Loading words into anagram finder...");
            DateTime before = DateTime.Now;
            anagramFinder.LoadWords(WordList);
            DateTime after = DateTime.Now;
            TimeSpan span = new TimeSpan(after.Ticks - before.Ticks);
            Console.WriteLine("Loaded " + WordList.Length + " words in " + span.TotalMilliseconds + " ms.");

            Console.WriteLine("Finding anagrams");
            List<string> searchList = new List<string>(WordList);
            List<Anagram> Anagrams = new List<Anagram>();
            before = DateTime.Now;
            int maxWordLength = 0;
            while (searchList.Count > 0)
            {
                var word = searchList[0];
                var a = anagramFinder.FindAnagram(word);
                if (a != null)
                {
                    if (word.Length > maxWordLength)
                        maxWordLength = word.Length;
                    Anagrams.Add(a);
                    foreach(var w in a)
                    {                        
                        searchList.Remove(w);
                    }
                }
                else
                {
                    searchList.Remove(word);
                }
            }
            after = DateTime.Now;
            span = new TimeSpan(after.Ticks - before.Ticks);
            Console.WriteLine("Found " + Anagrams.Count + " anagrams in " + span.TotalMilliseconds + " ms.");
            int maxSquare = 0;
            foreach (var a in Anagrams)
            {
                Console.Write(a.ToString() + "  ");
                int[] squareAnagrams = a.FindSquareAnagrams();
                if (squareAnagrams.Length > 0)
                {
                    foreach(var pr in squareAnagrams)
                    {
                        if (pr > maxSquare) maxSquare = pr;
                        Console.Write(" " + pr.ToString());
                    }                    
                }
                Console.WriteLine();
            }
            Console.WriteLine(maxSquare);
            Console.ReadLine();
        }

        public static string [] LoadWordsFromFile()
        {
            List<string> list = new List<string>();
            foreach(string lines in File.ReadAllLines("p098_words.txt"))
            {
                var words = lines.Split(",".ToCharArray());
                foreach(var word in words)
                {
                    list.Add(word.Replace("\"", ""));
                }
            }
            return list.ToArray();
        }
    }
}
