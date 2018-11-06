using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Class: CSE 1321L
// Section: 08
//Term: Fall 18
// Instructor: Kristin Hegna
// Name: William P. Bailey II
// Lab#: 5

namespace BestDeal
{
	class BestDeal
	{
		static void Main(string[] args)
		{
			//Read user input of box type, weight and price
			Console.WriteLine("Enter small box weight (pounds): ");
			double sbw = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Enter small box price: ");
			double sp = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Enter large box weight (pounds): ");
			double lbw = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Enter large box price: ");
			double lp = Convert.ToDouble(Console.ReadLine());

			//Print user input small box weight, small box price, large box weight, and large box price
			Console.WriteLine("Small box weight: " + sbw + " Pounds");
			Console.WriteLine("Small box price: " + sp + " Dollars");

			Console.WriteLine("Large box weight: " + lbw + " Pounds");
			Console.WriteLine("Laarge box price: " + lp + " Dollars");

			//Calculate best deal and print judgement
			if ((sp / sbw) == (lp / lbw))
			{
				Console.WriteLine("Judgement: Both boxes are of the same value");
			}
			else if ((sp / sbw) > (lp / lbw))
			{
				Console.WriteLine("Judgement: The large box is a better deal");
			}
			else
			{
				Console.WriteLine("Judgement: The small box is a better deal");
			}
			Console.ReadLine();

		}
	}
}
