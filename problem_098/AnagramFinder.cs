using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using AWA.TernarySearchTree;

namespace problem_098
{
    class AnagramFinder
    {
        public TstDictionary<string, string> dictionary;
        public const int MIN_LENGTH = 3;
        private int word_length;

        public AnagramFinder()
        {
            dictionary = new TstDictionary<string, string>();
        }

        public void LoadWords(IEnumerable<string>words)
        {
            dictionary.Clear();
            foreach (var w in words)
                dictionary[w] = w;
            dictionary.BalanceSearchTree();
        }

        public Anagram FindAnagram(string line)
        {
            word_length = line.Length;
            Anagram a = null;
            List<string> results = new List<string>();
            SearchChar[] chars = CreateSearchArray(line);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < chars.Length; ++i)
                search(results, chars, i, 0, sb);

            if (results.Count > 1)
            {
                results.Sort(CompareWordsByLength);
                a = new Anagram(results);
            }                       
            return a;
        }
        
        private static int CompareWordsByLength(string x, string y)
        {
            if (x == null)
            {
                if (y == null)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                if (y == null)
                {
                    return 1;
                }
                else
                {
                    int retval = y.Length.CompareTo(x.Length);

                    if (retval != 0)
                    {
                        return retval;
                    }
                    else
                    {
                        return x.CompareTo(y);
                    }
                }
            }
        }

        SearchChar[] CreateSearchArray(string line)
        {
            SearchChar[] items = new SearchChar[line.Length];
            for (int i = 0; i < line.Length; ++i)
            {
                items[i] = new SearchChar();
                items[i].c = line[i];
                items[i].searched = false;
            }
            return items;
        }

        private void search(List<string> results, SearchChar[] chars, int pos, int depth, StringBuilder sb)
        {
            if (depth >= word_length || chars[pos].searched)
            {
                return;
            }
            
            sb.Append(chars[pos].c);
            string key = sb.ToString();           
            if (depth > 0 && !dictionary.PartialKeyExists(key))
            {
                sb.Remove(depth, 1);
                return;
            }
            chars[pos].searched = true;
            string value = dictionary[key];
            if (value != null && value.Length == word_length && !results.Contains(value)) results.Add(value);
            for (int i = 0; i < chars.Length; ++i)
            {
                if (i != pos && !chars[i].searched)
                {
                    search(results, chars, i, depth + 1, sb);
                }
            }
            sb.Remove(depth, 1);
            chars[pos].searched = false;
        }
    }

    struct SearchChar
    {
        public char c;
        public bool searched;       
    }

}
