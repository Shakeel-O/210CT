/*
 * Created by SharpDevelop.
 * User: shakeel
 * Date: 25/10/2016
 * Time: 09:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace removeVowels
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Enter your word:");
			Console.WriteLine(remove(Console.ReadLine()));
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static string remove(string word){
			char[] vowels ={'a','e','i','o','u','A','E','I','O','U'};
			//checks if there are any vowels left in the word
			if (word.IndexOfAny(vowels) == -1) {
				return word;
			}
			else{
				//gets rid of one vowel each time
				word = word.Remove(word.IndexOfAny(vowels),1);
			}
			return (remove(word));
		}
	}
}