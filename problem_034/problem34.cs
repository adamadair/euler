using System;
using System.Linq;

namespace Problem34
{
	class Program
	{
		public static void Main (string[] args)
		{
			int sum = 0;
			for (int i = 3; i < 50000; ++i) {
				if (i ==DigitFactorialSum (i))
					sum += i;
			}
			Console.WriteLine (sum.ToString ());
		}

		static int DigitFactorialSum(int i){
			int sum = 0;
			foreach (var d in i.ToString().ToCharArray()) {
				sum += Factorial (int.Parse (d.ToString ()));	
			}
			return sum;
		}
		private static int Factorial(int i)
		{
			return i < 0 ? -1 : i == 0 || i == 1 ? 1 : Enumerable.Range(1, i).Aggregate((counter, value) => counter * value);
		}
	}
}