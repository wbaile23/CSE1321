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

namespace LocalLargestElement
{
	class LocateLargestElement
	{
		static void Main(string[] args)
		{
			int[,] Array1 = new int[3, 4];
			Console.WriteLine("Enter 12 integers: ");

			for (int x = 0; x < Array1.GetLength(0); x++)
			{
				for (int y = 0; y < Array1.GetLength(1); y++)
				{
					Array1[x, y] = Convert.ToInt32(Console.ReadLine());
				}
			}
			Console.WriteLine("The entered matrix: ");
			for (int x = 0; x < 3; x++)
			{
				Console.Write("\t");
				for (int y = 0; y < 4; y++)
				{
					Console.Write(Array1[x, y] + " ");

					{
						if ((y + 1) % 4 == 0)
						{
							Console.WriteLine();
						}
					}

				}
			}
			Console.WriteLine();
			LocateLargest(Array1);
			Console.WriteLine();
			Console.ReadLine();
		}
		public static void LocateLargest(int[,] a)
		{
			int row = 0;
			int col = 0;
			int largest = 0;
			int lrow = 0;
			int lcol = 0;
			for (row = 0; row < 3; row++)
			{
				for (col = 0; col < 4; col++)
				{
					int prev = a[row, col];
					if (largest < prev)
					{
						largest = prev;
						lrow = row;
						lcol = col;

					}
				}
			}
			Console.WriteLine("First largest value is located at " + lrow + " and column " + lcol);
			
		}
	}

}
