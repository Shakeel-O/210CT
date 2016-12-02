/*
 * Created by SharpDevelop.
 * User: shakeel
 * Date: 10/10/2016
 * Time: 17:21
 *
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;
using System.Collections.Generic;

namespace question1
{
	class Program
	{
		public static void Main(string[] args)
		{
			do {
				shuffle();
				Console.WriteLine("Type 'Y' to restart...");
			} while(Console.ReadKey().Key == ConsoleKey.Y);
			// with the addition of this loop the big O notation is O(n^3)
			// but this is simply for testing purposes (for the accessor)
		}
		private static void shuffle()
		{
			List<int> arr = new List<int>(new []{5, 3, 8, 6, 1, 9, 2, 7 });
			int[] shuffled = new int[arr.Count];
			Random rand = new Random();
			int value;
			for (int i = arr.Count-1; i >= 0; i--) {
				value = rand.Next(arr.Count);// gets a new random integer
				shuffled[i]= arr[value];
				arr.RemoveAt(value);//removes element so it isnt used again
				if (i == 0) {
					Console.WriteLine("{0}", shuffled[i]);
				} else {
					Console.Write("{0}, ", shuffled[i]);
				}
				//the Big O notation of this is O(n^2)
			}
		}
	}
}