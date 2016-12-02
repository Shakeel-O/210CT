/*
 * Created by SharpDevelop.
 * User: shakeel
 * Date: 17/10/2016
 * Time: 22:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace perfectSquare
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("enter a number");
			double squared;
		 	if (double.TryParse(Console.ReadLine(), out squared)) {
		 		Console.WriteLine(sqroot(squared));
		 	}
		 	else{
		 		Console.WriteLine("A number needs to be entered in order for this to work");
		 	}
			Console.ReadKey(true);
		}
		public static double sqroot(double number)
		{
			for (int i = 1; i < number; i++) {
				if (i * i > number) {
					number = (i - 1) * (i - 1);
					break;
				}
				if (i * i == number) {
					return (i * i);
				}
			}	
			return(number);
		}
	}
}