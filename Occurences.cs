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
//Assignment: 7

namespace Assign7_Occurences
{
	class Occurences
	{
		public static void Main(string[] args)
		{
			int[] size = new int[10];

			Console.WriteLine("Enter 10 integers: ");

			for (int i = 0; i < 10; i++)
			{
				size[i] = Convert.ToInt32(Console.ReadLine());
			}
			Console.WriteLine("Entered integers: ");
			Console.WriteLine();
			PrintArray(size);
			Console.WriteLine();
			Console.WriteLine();
			Count(size);
			Console.ReadLine();
		}
		public static void PrintArray(int[] size)
		{
			for (int i = 0; i < 10; i++)
			{
				Console.Write(size[i] + " ");
			}
		}
		public static void Count(int[] size)
		{
			for (int i = 0; i < 10; i++)

			{
				int count = 0;
				int value = size[i];
				bool prevOccur = false;
				for (int v = 0; v < i; v++)
				{
					if (size[i] == size[v])
					{
						prevOccur = true;
					}
				}
				if (prevOccur == false)
				{
					foreach (int n in size)
					{
						if (value == n)
						{
							count++;
						}
					}
					Console.WriteLine(value + " occured " + count + " times");
				}
			}
			
		}
	}
}
