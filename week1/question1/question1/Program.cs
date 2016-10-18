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

namespace question1
{
	class Program
	{
		public static void Main(string[] args)
		{
			string restart = "n";
			do{
				shuffle();
				Console.WriteLine("Do you want to restart (Y/N)");
				restart = Console.ReadLine().ToLower();
			}while(restart == "y");
			Console.ReadKey(true);
		}
		private static void shuffle(){
			int[] arr = {5,3,8,6,1,9,2,7};
			int[] shuffled = new int[8];
			Random rand = new Random();
			int value;
			Console.Write("["); //for getting the output desired (formatting)
			for (int i = 0; i < 8; i++) {
				do{
					// gets a random index
					value = arr[rand.Next(8)];
				}// if the value is 4 or already has the value then get another random int
				while (shuffled.Contains(value));
				shuffled[i] = value;
				if (i == 0) {
					Console.Write("{0}", shuffled[i]);
				}
				else{
				Console.Write(", {0}", shuffled[i]);
				}
			}
			Console.WriteLine("]");	
		}
	}
}