/*
 * Created by SharpDevelop.
 * User: shakeel
 * Date: 04/10/2016
 * Time: 23:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;

namespace question6
{
	class Program
	{
		public static void Main(string[] args)
		{
			int[] test = {1,4,6,7,2};
			Console.WriteLine("Max is {0} on position {2}, Min is {1} on position {3}", test.Max(), test.Min(), Array.IndexOf(test, test.Max())+1, Array.IndexOf(test, test.Min())+1 );
			

			Console.ReadKey(true);
		}
	}
}