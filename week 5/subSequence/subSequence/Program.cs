/*
 * Created by SharpDevelop.
 * User: shakeel
 * Date: 07/11/2016
 * Time: 17:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace subSequence
{
	class Program
	{
		public static void Main(string[] args)
		{
			int[] sequence = { 1, 2, 3, 5, 4, 7, 8, 9, 8, 6, 4, 1, 3, 4, 5, 6, 7, 8, 9 };
			List<int> sub = new List<int>();
			int count = 0;
			int first = -1;
			bool finished = false;
			int longest_first = -1;
			int longest_last = -1;
			
			for (int i = 0; i < sequence.Length; i++) {
				if (finished) {
					sub.Add(sequence[i - 1]);
					count += 1;
					if (i == longest_last) {
						break;
					}
				} else {
					if (i == 0) {
						first = i;
					} 
					else if (sequence[i] < sequence[i - 1]) {
						if (longest_first == -1) {
							longest_first = longest_last + 1;
							longest_last = i - 1;
							first = i;
						} else if ((i - first) >= (longest_last - longest_first)) {
							longest_first = longest_last + 1;
							longest_last = i - 1;
							first = i;
						}
					}
					if (i == sequence.Length - 1) {
						finished = true;
					
						if ((i - first) >= (longest_last - longest_first)) {
							longest_first = longest_last + 1;
							i = longest_first;
							longest_last = i;
						
						} else {
							i = longest_first - 1;
						}
					}
				}
				
			}
			sub.ForEach(Console.Write);
			Console.WriteLine();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
			/* the Big O notation of this is O(n^2)*/
		}
	}
}