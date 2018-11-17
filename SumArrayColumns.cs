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
//Lab: 13

namespace SumArryColumns
{
	class SumArrayColumns
	{
		static void Main(string[] args)
		{
			int[,] Array1 = new int[3, 4];
			Console.WriteLine("Enter 12 integers: ");
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 4; j++)
				{
					Array1[i, j] = Convert.ToInt32(Console.ReadLine());
				}
			}
			Console.WriteLine("The entered matrix:");
			Console.Write("\t");
			for (int o = 0; o < 3; o++)
			{
				for (int p = 0; p < 4; p++)
				{

					int num = Array1[o, p];

					Console.Write(num + " ");
					if ((p + 1) % 4 == 0)
					{
						Console.WriteLine();
						Console.Write("\t");
					}
				}
			}
			Console.WriteLine();
			for (int col = 0; col < Array1.GetLength(1); col++)
			{
				int sum = SumColumn(Array1, col);
				Console.WriteLine("Sum of col " + col + " is " + sum);
			}
			int SumColumn(int[,] SumArray, int col)
			{
				int sum = 0;
				for (int row = 0; row < Array1.GetLength(0); row++)
				{
					sum = sum + Array1[row, col];
				}
				return sum;
			}
			Console.ReadLine();
		}
	}
}

