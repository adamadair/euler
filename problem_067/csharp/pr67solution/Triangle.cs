using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace pr18solution
{
    /// <summary>
    /// The triangle structure.
    /// </summary>
    class Triangle
    {
        private string file;
        private int[][] triangle;
        private int rows;        

        public Triangle(string f)
        {
            file = f;
            Init();
        }

        private void Init()
        {
            rows = 0;
            List<int[]> rowList = new List<int[]>();
            string[] lines = File.ReadAllLines(file);
            foreach (var line in lines)
            {
                List<int> intList = new List<int>();
                string[] digits = line.Split(" ".ToCharArray());
                foreach (var digit in digits)
                    intList.Add(Int32.Parse(digit));
                rowList.Add(intList.ToArray());
                ++rows;
            }
            triangle = rowList.ToArray(); // the result is a two dimensional array.                                          
        }

        public int GetMaxTotal()
        {
            int maxValue = 0;
            int[] last = { };
            for(int i = 0; i < triangle.Length; ++i)
            {
                int[] row = new int[triangle[i].Length];
                for(int j = 0; j < triangle[i].Length; ++j)
                {
                    row[j] = triangle[i][j];
                    if (i > 0)
                    {
                        // calculate path values
                        if (j == 0) { row[j] += last[j]; }
                        else if (j == last.Length) { row[j] += last[j - 1]; }
                        else
                        {
                            if (last[j - 1] > last[j])
                                row[j] += last[j - 1];
                            else
                                row[j] += last[j];
                        }
                    }
                }
                last = row;                
            }
            foreach(int val in last)
            {
                if (val > maxValue) { maxValue = val; }
            }
            return maxValue;
        }
    }
}
