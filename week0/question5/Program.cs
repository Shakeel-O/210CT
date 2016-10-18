/*
 * Created by SharpDevelop.
 * User: shakeel
 * Date: 04/10/2016
 * Time: 20:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace question5
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("please enter the day of the month");
			int day = int.Parse(Console.ReadLine());
			Console.WriteLine("please enter the month");
			int month = int.Parse(Console.ReadLine());
			Console.WriteLine("please enter the year");
			int year = int.Parse(Console.ReadLine());
			int daysleft = 0;
			int daysthismonth = System.DateTime.DaysInMonth(year, month) - day;
			int daysgone = 0;
			for (int i = month+1; i < 13; i++) {
				Console.WriteLine(i);
				daysleft += System.DateTime.DaysInMonth(year, i);
			}
			for (int i = month-1; i > 0; i--) {
				Console.WriteLine(i);
				daysgone += System.DateTime.DaysInMonth(year, i);
			}
			// +1 and -1 because the day has not gone yet so needs to be added to the days left
			Console.WriteLine("{0} days passed, {1} days left", daysgone + day -1, daysleft+ daysthismonth +1);
			Console.ReadKey(true);
		}
	}
}