using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharShape
{
	class CharShape
	{
		static void Main(string[] args)
		{
			//Capture user input number of rows and columns (which is same #)
			Console.WriteLine("Input number of rows/ columns: ");
			int num = Convert.ToInt32(Console.ReadLine());	//Intiate "num" as user input integer

			//Capture user input char wanted to use in shape
			Console.WriteLine("Input character desired: ");
			char o = Convert.ToChar(Console.ReadLine());	//Intiate "o" as user input character

			Console.WriteLine();    //Prints empty line to seperate Output from User Input

			//For loop to write user char until > user input num
			for (int i = 0; i < num; i++)	//intiate i as counter rows (across), counts till > num, adds 1 to i until > num
			{
				for (int j = 0; j < num ; j++)	//For loop inside for loop intiate j as counter Column (down), counts till > num, adds 1 to j until > num
				{
						Console.Write(o);	//Prints user input char across
				}
				Console.WriteLine(o);	//Prints user input char down (must be outside inter loop)
			}
			Console.ReadLine();
		}
	}
}
