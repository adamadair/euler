using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace solution24
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int max = 10;
			string[] digits = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
			var els = digits.Combinations (max);
			foreach (var e in els) {
				Console.WriteLine (e);
			}
			//Console.WriteLine (digits.Combinations (max).ElementAt (max - 1).ToString ());
			Console.WriteLine ();
				
		}


	}

	public static class Combo
	{
		public static IEnumerable<IEnumerable<T>> Combinations<T>(this IEnumerable<T> elements, int k)
		{
			return k == 0 ? new[] { new T[0] } :
			elements.SelectMany((e, i) =>
				elements.Skip(i + 1).Combinations(k - 1).Select(c => (new[] {e}).Concat(c)));
		}
	}
}
