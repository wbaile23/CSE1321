using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
	class SearchNum			//Takes in 9 user numbers, display them in order entered, 
							//display again after Bubble Sort, then Binary Search for a number
	{
		static void Main(string[] args)
		{
			int[] Binary1 = new int[9];
			int row = 0;
			Console.WriteLine("Enter 9 integers: ");
			for (row = 0; row < Binary1.GetLength(0); row++)
			{
				Binary1[row] = Convert.ToInt32(Console.ReadLine());
			}
			Console.WriteLine();
			Console.Write("Thank you. \nThe numbers you entered are ");

			for (row = 0; row < Binary1.GetLength(0) - 1; row++)
			{
				Console.Write(Binary1[row] + ", ");
				if (row == 7)
				{
					Console.WriteLine(Binary1[row + 1]);
				}
			}
			Console.WriteLine();
			Console.WriteLine("Those numbers after bubble sorting (numerical order)");

			Sort(Binary1);
			for (row = 0; row < Binary1.GetLength(0) - 1; row++)
			{
				Console.Write(Binary1[row] + ", ");
				if (row == 7)
				{
					Console.WriteLine(Binary1[row + 1]);
				}
			}
			Console.WriteLine();
			Console.Write("Enter the number you would like to search for: ");
			int num = Convert.ToInt32(Console.ReadLine());
			if (BinarySearch(Binary1, num) == true)
			{
				Console.WriteLine("Congratulations.  We found: " + num);
			}
			else
			{
				Console.WriteLine("Number not found.  Sorry..");
			}

			Console.ReadLine();
		}
		static bool BinarySearch(int[] a, int find)		//Method to look for a certain number in array
		{
			bool found = false;
			int low = 0;
			int high = a.GetLength(0);
			int mid = 0;
			while (!found)
			{
				mid = (low + high) / 2;
				if (find == a[mid])
				{
					return true;
				}
				else if (find < a[mid])
				{
					high = mid;
				}
				else
				{
					low = mid;
				}
				if (low >= high - 1)
				{
					return false;
				}
			}
			return found;
		}
		static void Sort(int[] s)		//Method to sort numbers entered and put Array values in numeric order.
		{
			for (int i = 0; i < s.GetLength(0) - 1; i++)
			{
				for (int j = i + 1; j < s.GetLength(0); j++)
				{
					if (s[j] < s[i])
					{
						int temp = s[j];
						s[j] = s[i];
						s[i] = temp;
					}
				}
			}

		}

	}
}
