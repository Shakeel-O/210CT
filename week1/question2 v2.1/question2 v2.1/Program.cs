/*
 * Created by SharpDevelop.
 * User: shakeel
 * Date: 11/10/2016
 * Time: 14:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace question2_v2._
{
	class Program
	{
		public static void Main(string[] args)
		{
			string continues = "n";
			do{
			trailing();
			Console.WriteLine("start again? Y/N");
			continues = Console.ReadLine().ToLower();
			}
			while (continues == "y");
		}
		public static void trailing(){
			Console.WriteLine("Enter a number");
			double input = Convert.ToInt32(Console.ReadLine());
			double output = 0;
			while (input > 0) {
				input = Math.Floor(input/5);
				output += input;
			}Console.WriteLine(output);

		}
	}
}