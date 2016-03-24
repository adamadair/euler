using System;
using System.Text;

namespace Problem40
{
    class MainClass
    {
        public static void Main (string[] args)
        {
            StringBuilder sb = new StringBuilder ();
            for (int i = 1; i <= 500000; ++i) {
                sb.Append (i.ToString ());
            }
            int solution = 1;
            var str = sb.ToString ();
            //d1 × d10 × d100 × d1000 × d10000 × d100000 × d1000000
            solution *= Int32.Parse (str [0].ToString());
            solution *= Int32.Parse (str [10 - 1].ToString());
            solution *= Int32.Parse (str [100 - 1].ToString());
            solution *= Int32.Parse (str [1000 - 1].ToString());
            solution *= Int32.Parse (str [10000 - 1].ToString());
            solution *= Int32.Parse (str [100000 - 1].ToString());
            solution *= Int32.Parse (str [1000000 - 1].ToString());
            Console.WriteLine (solution.ToString ());
        }
    }
}
