/*
 * Created by SharpDevelop.
 * User: shakeel
 * Date: 01/11/2016
 * Time: 10:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace BinarySearchRange
{
	class Program
	{
		public static void Main(string[] args)
		{
			int[] L = {2,3,5,7,9,13};
			Console.WriteLine(binarySearch(L ,Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine()) ) );
			Console.ReadKey(true);
		}
		public static bool binarySearch(int[] L, int low, int high){
			int first = 0;
			int last = L.Length;
			while (last > first) {
				int mid = first + (last-first)/2;
				if (L[mid] <= high && L[mid] >= low) {
					return true;
				}
				if (L[mid] < low) {
					first = mid + 1;
				}
				else{
					last = mid - 1;
				}
			}
			return false;
		}
	}
}