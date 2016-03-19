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
			//int max = 10;
			string[] digits = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

			string[] lp = LexoPerm (digits, 1000000-1);

			PrintArray (lp);
			//Console.WriteLine (digits.Combinations (max).ElementAt (max - 1).ToString ());
			Console.WriteLine ();
				
		}

		/// <summary>
		/// Returns the nth lexographic permutation of the array.
		/// 
		/// 1. Find the largest index `k` such that `a[k] < a[k + 1]`. 
		/// If no such index exists, the permutation is the last permutation.
		/// 
		/// 2. Find the largest index `l` greater than k such that `a[k] < a[l]`.
		/// 
		/// 3. Swap the value of `a[k]` with that of `a[l]`.
		/// 
		/// 4. Reverse the sequence from `a[k + 1]` up to and including the final element `a[n]`.
		/// </summary>
		/// <returns>The kth permutation. If there are not k perumutations the last 
		/// permutation is returned.</returns>
		/// <param name="sArrray">the array</param>
		/// <param name="n">which permutation to return</param>
		private static string [] LexoPerm(string [] sArray, int n)
		{
			int length = sArray.Length;
			var tmpArray = new string[length];
			Array.Copy (sArray, tmpArray, length);
			for (int i = 0; i < n; ++i) {

				// 1. Find the largest index `k` such that `a[k] < a[k + 1]`. 
				// If no such index exists, the permutation is the last permutation.
				int k = tmpArray.Length - 2; //point k to the last element in the array
				while (k >= 0 && tmpArray[k].CompareTo(tmpArray[k+1])>=0){ // >= tmpArray [k + 1]) {
					--k;
				}
				if (k < 0)
					return tmpArray;

				// 2. Find the largest index `l` greater than k such that `a[k] < a[l]`.
				int l = length-1;
				while(tmpArray[l].CompareTo(tmpArray[k])<=0){
					--l;
				}

				// 3. Swap the value of `a[k]` with that of `a[l]`.
				Swap(tmpArray,k,l);

				// 4. Reverse the sequence from `a[k + 1]` up to and including the final element `a[n]`.
				Reverse(tmpArray, k+1, length-1);
				//PrintArray (tmpArray);
			}
			return tmpArray;
		}

		private static void Swap(string []sArray, int k, int l)
		{
			string tmp = sArray [k];
			sArray [k] = sArray [l];
			sArray [l] = tmp;
		}

		private static void PrintArray(string []sa){
			foreach (var d in sa)
				Console.Write (d);
			Console.WriteLine ();

		}

		private static void Reverse(string []sArray, int start, int end)
		{
			if (start < 0 || start >= sArray.Length || end < 0 || end >= sArray.Length)
				return;
			while (start < end) {
				Swap (sArray, start, end);
				++start;
				--end;
			}
		}
	}
}
