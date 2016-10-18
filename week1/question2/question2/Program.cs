/*
 * Created by SharpDevelop.
 * User: shakeel
 * Date: 11/10/2016
 * Time: 10:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace question2
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("enter a number");
			int number = factorial(Convert.ToInt32(Console.ReadLine()));
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static int factorial(int n){
			int numbers = 1;
			for (int i = 10; i == 1; i--) {
				numbers *= i;
			}
			Console.WriteLine(numbers);
			return(numbers);
		}
	}
}