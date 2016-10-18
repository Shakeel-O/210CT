/*
 * Created by SharpDevelop.
 * User: shakeel
 * Date: 04/10/2016
 * Time: 13:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace question3
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("please enter a number");
			string input = Console.ReadLine();
			float x = float.Parse(input);
			f(x);
			Console.ReadKey();
		}
		public static void f(float x){
			if (x > - 2){
				x = (float)(Math.Pow(x,2)) + (5*x);
			}
			else if (x<-2){
				x = (float)(Math.Pow(x,2)) + (4 *x) + 4;
				}
			else if (x == 0){
				x =0;
			}
			Console.WriteLine(x);
			
		}
	}
}