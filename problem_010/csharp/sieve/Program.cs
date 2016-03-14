using System;

namespace sieve
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			PrimeSieve sieve = new PrimeSieve (2000000);
			Console.WriteLine ("sum = {0}",sieve.SumOfPrimes);
		}
	}
}
