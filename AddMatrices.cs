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

namespace Lab13_AddMatrices
{
	class AddMatrices
	{
		static void Main(string[] args)
		{
			int[,] MatrixA = new int[3, 3];
			int[,] MatrixB = new int[3, 3];

			Console.WriteLine("Enter 9 integers for Matrix A: ");
			for (int row = 0; row < 3; row++)
			{
				for (int col = 0; col < 3; col++)
				{
					MatrixA[row, col] = Convert.ToInt32(Console.ReadLine());
				}
			}
			Console.WriteLine("Enter 9 integers for Matrix B: ");
			for (int row = 0; row < 3; row++)
			{
				for (int col = 0; col < 3; col++)
				{
					MatrixB[row, col] = Convert.ToInt32(Console.ReadLine());
				}
			}
			Console.WriteLine("Matrix A:");

			for (int x = 0; x < 3; x++)
			{
				Console.Write("   ");
				for (int y = 0; y < 3; y++)
				{
					Console.Write(MatrixA[x, y] + " ");
				}
				Console.WriteLine();
			}
			Console.WriteLine();

			Console.WriteLine("Matrix B:");

			for (int x = 0; x < 3; x++)
			{
				Console.Write("   ");
				for (int y = 0; y < 3; y++)
				{
					Console.Write(MatrixB[x, y] + " ");
				}
				Console.WriteLine();
			}
			Console.WriteLine();
			Console.WriteLine("A + B:");
			Addition(MatrixA, MatrixB);
			Console.ReadLine();
		}
		static void Addition(int[,] a, int[,] b)
		{
			for (int x = 0; x < 3; x++)
			{
				Console.Write("   ");
				for (int y = 0; y < 3; y++)
				{
					Console.Write((a[x, y] + b[x, y]) + " ");
				}
				Console.WriteLine();
			}
		}
	}
}
