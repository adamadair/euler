using System;
using System.Collections.Generic;

namespace Problem39
{
	class MainClass
	{
		public static void Main (string[] args)
		{
            var perimeters = new Dictionary<int,int> ();
            for (int a = 1; a <= 500; ++a)
                for (int b = 1; b <= 500; ++b)
                    for (int c = 1; c <= 500; ++c) {
                        if (Math.Pow (a, 2) + Math.Pow (b, 2) == Math.Pow (c, 2)) {
                            int p = a + b + c;
                            if (perimeters.ContainsKey (p))
                                perimeters [p] = perimeters [p] + 1;
                            else
                                perimeters [p] = 0;
              
                        }
                    }

            KeyValuePair<int,int> val = new KeyValuePair<int,int>(0,0);
            foreach (var v in perimeters) {
                if (v.Value > val.Value)
                    val = v;
            }
            Console.WriteLine (val.Key.ToString ());
            Console.ReadLine ();
		}
	}
}
