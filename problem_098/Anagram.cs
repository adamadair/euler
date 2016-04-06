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

        public int[] FindPrimeAnagrams()
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
            List<int> primes = new List<int>();
            Search(primes, 0, new List<SearchChar>());
            return primes.ToArray();
        }

        private void Search(List<int>primes, int depth, List<SearchChar> chars)
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
                    Search(primes, depth, chars);
                }
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
                    pattern = pattern.Replace("{" + i + "}", chars[i].ToString());
                }
                int num = int.Parse(pattern);
                if (num.IsPrime())
                {
                    l.Add(num);
                }
            }
            if (l.Count > 1)
            {
                primes.AddRange(l);
            }
        }
    }


}
