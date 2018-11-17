using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Class: CSE 1321L
//Section: 08
//Term: Fall 18
//Instructor: Kristin Hegna
//Name: William P. Bailey II
//Lab#: 3

namespace SimpleMath
{
	class SimpleMath
	{
		static void Main(string[] args)
		{
			//Read user input numbers
			Console.WriteLine("Enter first number (R): ");
			double R = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Enter second number (T): ");
			double T = Convert.ToDouble(Console.ReadLine());

			//Compute addition, subtraction,and multiplication of numbers
			double added = R + T;
			double minus = R - T;
			double multiply = R * T;

			//Print entered numbers and math solutions
			Console.WriteLine("R = " + R);
			Console.WriteLine("T = " + T);
			Console.WriteLine("R + T = " + added);
			Console.WriteLine("R - T = " + minus);
			Console.WriteLine("R * T = " + multiply);
			Console.ReadLine();
		}
	}
}
