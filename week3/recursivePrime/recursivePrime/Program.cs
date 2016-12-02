/*
 * Created by SharpDevelop.
 * User: shakeel
 * Date: 25/10/2016
 * Time: 00:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace recursivePrime
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("enter number");
			// division starts with 2 because 1 and 0 can't be primes
			Console.WriteLine(isPrime(2, 127));
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static string isPrime(int test, int number){
			if (number == 0 || number == 1) {
				return number + " cannot be a prime number";
			}
			// if test reaches the number then its not divisible by any lower numbers
			if (test == number) {
				return number + " is a prime number";
			}
			//checks if the modulus (remainder by division) of number by test will result in 0
			if (number % test == 0) {
				return number + " is not a prime number, it is divisible by " + test;
			}
			return isPrime(test+1,number);
		}
	}
}