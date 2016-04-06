using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EulerLib;

namespace problem_098
{
    public class Anagram : List<string>
    {
        string[] patterns;
        SearchChar[] searchDigits;
        int uniqueDigits;
        public Anagram(IEnumerable<string> words) : base(words)
        {
            char[] chars = "0123456789".ToCharArray();
            searchDigits = new SearchChar[10];
            for (int i = 0; i < chars.Length; ++i)
            {
                searchDigits[i] = new SearchChar { c = chars[i], searched = false };
            }

        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (this.Count > 0)
            {
                sb.Append(this[0]);
                for (int i = 1; i < this.Count; ++i)
                {
                    sb.Append(", " + this[i]);
                }
            }
            return sb.ToString();
        }

        public int[] FindSquareAnagrams()
        {
            generatePatterns();
            List<int> squares = new List<int>();
            SearchForSquares(squares, 0, new List<SearchChar>());
            return squares.ToArray();
        }


        public int[] FindPrimeAnagrams()
        {
            generatePatterns();
            List<int> primes = new List<int>();
            SearchForPrimes(primes, 0, new List<SearchChar>());
            return primes.ToArray();
        }

        private void generatePatterns()
        {
            char[] letters = this[0].Distinct().ToArray();
            uniqueDigits = letters.Length;
            List<string> pats = new List<string>();
            foreach (var word in this)
            {
                string w = word;
                for (int i = 0; i < letters.Length; ++i)
                {
                    w = w.Replace(letters[i].ToString(), "{" + i.ToString() + "}");
                }
                pats.Add(w);
            }
            patterns = pats.ToArray();
        }

        private void SearchForSquares(List<int> squares, int depth, List<SearchChar> chars)
        {
            ++depth;
            for (int i = 0; i < 10; ++i)
            {
                if (i == 0 && depth == 1) continue;
                if (searchDigits[i].searched) continue;
                searchDigits[i].searched = true;
                chars.Add(searchDigits[i]);
                if (depth == uniqueDigits)
                {
                    CheckPatternsForSquares(squares, chars);
                }
                else
                {
                    SearchForSquares(squares, depth, chars);
                }
                chars.Remove(searchDigits[i]);
                searchDigits[i].searched = false;
                //if (squares.Count > 0) return;
            }
        }

        private void CheckPatternsForSquares(List<int> primes, List<SearchChar> chars)
        {
            List<int> l = new List<int>();
            foreach (var p in patterns)
            {
                string pattern = p;
                for (int i = 0; i < chars.Count; ++i)
                {
                    pattern = pattern.Replace("{" + i + "}", chars[i].c.ToString());
                }
                if (pattern.First() != '0')
                {
                    int num = int.Parse(pattern);
                    if (num.IsSquare())
                    {
                        l.Add(num);
                    }
                    else
                        return;
                }
                else return;
            }
            primes.AddRange(l);
        }

        #region Search for Primes

        private void SearchForPrimes(List<int>primes, int depth, List<SearchChar> chars)
        {
            ++depth;
            for(int i = 0; i < 10; ++i)
            {
                if (i == 0 && depth == 1) continue;
                if (searchDigits[i].searched) continue;
                searchDigits[i].searched = true;
                chars.Add(searchDigits[i]);
                if (depth == uniqueDigits)
                {
                    CheckPatternsForPrime(primes, chars);
                } else
                {
                    SearchForPrimes(primes, depth, chars);
                }
                chars.Remove(searchDigits[i]);
                searchDigits[i].searched = false;
                if (primes.Count > 0) return;
            }
        }

        private void CheckPatternsForPrime(List<int>primes, List<SearchChar> chars)
        {
            List<int> l = new List<int>();
            foreach(var p in patterns)
            {
                string pattern = p;
                for(int i = 0; i < chars.Count; ++i)
                {
                    pattern = pattern.Replace("{" + i + "}", chars[i].c.ToString());
                }
                if (pattern.First() != '0')
                {
                    int num = int.Parse(pattern);
                    if (num.IsPrime())
                    {
                        l.Add(num);
                    }
                    else
                        return;
                }
                else return;
            }
           
            primes.AddRange(l);
            
        }
        #endregion

    }


}
