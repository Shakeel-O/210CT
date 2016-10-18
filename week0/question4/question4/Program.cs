/*
 * Created by SharpDevelop.
 * User: shakeel
 * Date: 04/10/2016
 * Time: 14:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace question4
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			Console.WriteLine("")
			string s = "beautiful";
			const int b = 3;
			const int l = 2;http://stackoverflow.com/posts/31804257/edit
			string remove = s.Substring(b,l);
			//s = s.Remove(b,l);
			s = s.Replace(remove,"");
			Console.WriteLine(s);
			Console.ReadKey(true);
		}
	}
}