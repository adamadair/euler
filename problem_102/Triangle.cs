using System.Drawing;

namespace problem_102
{
    class Triangle
    {
        public Triangle(string points)
        {
            string[] pArray = points.Split(",".ToCharArray());
            p0 = new Point(int.Parse(pArray[0]), int.Parse(pArray[1]));
            p1 = new Point(int.Parse(pArray[2]), int.Parse(pArray[3]));
            p2 = new Point(int.Parse(pArray[4]), int.Parse(pArray[5]));
        }

        private Point p0, p1, p2;
        public Point P0 { get { return p0; } }
        public Point P1 { get { return p1; } }
        public Point P2 { get { return p2; } }
    }
}
