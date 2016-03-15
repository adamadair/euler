using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace cs_problem11
{
    class Program
    {
        static void Main(string[] args)
        {
            Grid g = new Grid("grid.txt");
            Console.WriteLine("{0}", g.GetLargestProduct(4));
            Console.ReadLine();
        }
    }

    /// <summary>
    /// C# works best when following proper OOP principls, so 
    /// I am creating a Grid class, and reading the values in 
    /// from a file. This class does not assume that the grid
    /// is a proper rectangle, but not providing a proper 
    /// rectangular grid would result in incorrect results.
    /// </summary>
    class Grid
    {
        private string file;
        private int[][] grid;
        private int rows;
        private int cols;
        public Grid(string gridFile)
        {
            file = gridFile;
            Init();
        }
        
        private void Init()
        {
            rows = 0;
            List<int[]> rowList = new List<int[]>();
            string[] lines = File.ReadAllLines(file);
            foreach(var line in lines)
            {
                List<int> intList = new List<int>();
                string[] digits = line.Split(" ".ToCharArray());
                foreach (var digit in digits)
                    intList.Add(Int32.Parse(digit));
                rowList.Add(intList.ToArray());
                ++rows;
            }
            grid = rowList.ToArray(); // the result is a two dimensional array.
                                      // first dimension is row, second is column. 
            cols = grid[0].Length;
        }

        public int GetLargestProduct(int length)
        {
            if (length > rows || length > cols) return 0;
            int top_product = 0;
            for(int row = 0; row < rows; ++row)
            {
                for(int col = 0; col < cols; ++col)
                {
                    int val = horizonal(row, col, length);
                    if (val > top_product) top_product = val;
                    val = vertical(row, col, length);
                    if (val > top_product) top_product = val;
                    val = diagonal_down(row, col, length);
                    if (val > top_product) top_product = val;
                    val = diagonal_up(row, col, length);
                    if (val > top_product) top_product = val;
                }
            }
            return top_product;
        }

        private int horizonal(int row, int col, int length)
        {
            if (col + length - 1 >= cols) return 0;
            int prod = 1;            
            for (int i = 0; i < length; ++i) prod *= grid[row][col + i];
            return prod;
        }

        private int vertical(int row, int col, int length)
        {
            if (row + length - 1 >= rows) return 0;
            int prod = 1;            
            for (int i = 0; i < length; ++i) prod *= grid[row + i][col];
            return prod;
        }

        private int diagonal_down(int row, int col, int length)
        {
            if (col + length - 1 >= cols) return 0;
            if (row + length - 1 >= rows) return 0;
            int prod = 1;
            for (int i = 0; i < length; ++i) prod *= grid[row + i][col + i];
            return prod;
        }
        private int diagonal_up(int row, int col, int length)
        {
            if (col + length - 1 >= cols) return 0;
            if (row - length - 1 < 0) return 0;
            int prod = 1;
            for (int i = 0; i < length; ++i) prod *= grid[row - i][col + i];
            return prod;
        }
    }
}
