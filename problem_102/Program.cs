using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace problem_102
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;                 
            Point origin = new Point(0, 0);
            foreach(var t in GetTriangles())
            {
                if (PointInTriangle(origin, t))
                    ++sum;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }

        static List<Triangle> GetTriangles()
        {
            List<Triangle> list = new List<Triangle>();
            foreach(var line in File.ReadLines("p102_triangles.txt"))
            {
                list.Add(new Triangle(line));
            }
            return list;
        }

        static bool PointInTriangle(Point p, Triangle triangle)
        {
            Point p0 = triangle.P0;
            Point p1 = triangle.P1;
            Point p2 = triangle.P2;

            var s = p0.Y * p2.X - p0.X * p2.Y + (p2.Y - p0.Y) * p.X + (p0.X - p2.X) * p.Y;
            var t = p0.X * p1.Y - p0.Y * p1.X + (p0.Y - p1.Y) * p.X + (p1.X - p0.X) * p.Y;

            if ((s < 0) != (t < 0))
                return false;

            var A = -p1.Y * p2.X + p0.Y * (p2.X - p1.X) + p0.X * (p1.Y - p2.Y) + p1.X * p2.Y;
            if (A < 0.0)
            {
                s = -s;
                t = -t;
                A = -A;
            }
            return s > 0 && t > 0 && (s + t) <= A;
        }
    }
}
