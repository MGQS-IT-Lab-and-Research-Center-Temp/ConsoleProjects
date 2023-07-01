using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects
{
	public class Menu
	{
		public static void  StartMenu(int number)
		{
			Console.WriteLine("Enter" +
				"1.Calculate SimpleInterest" +
				"2.Calculate FIne" +
				"3.Get month name by number" +
				"4.Check Number is even or odd" +
				"5.Check is leap year");
			number = int.Parse(Console.ReadLine());
			switch(number)
			{
				case 3:
					Console.Write("Enter Month Number (1 - 12): ");
					int monthNumber = Convert.ToInt32(Console.ReadLine());
					Calendar.GetMonthByNumber(monthNumber);
				break;
			}
		}
	}
}
