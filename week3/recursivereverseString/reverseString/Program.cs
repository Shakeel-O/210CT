/*
 * Created by SharpDevelop.
 * User: shakeel
 * Date: 24/10/2016
 * Time: 23:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace recursiveReverseString
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("enter a string");
			string sentence  = Console.ReadLine();
			Console.WriteLine(reverse(sentence.Split(' '), sentence.Split(' ').Length-1,"")); // splits the words into an array using the spaces
			Console.WriteLine("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static string reverse(string[] words, int count, string output){
			// if the array will be out of index
			if (count == 0) {
				output += words[count];
				return output;
			}
			// reverses the array and adds to the string
			output += words[count] + " ";
			// changes the index of the array to get the next word
			return reverse(words,count-1, output);
		}
	}
}