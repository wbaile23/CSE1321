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

namespace PhoneBill
{
	class PhoneBill
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter account number: ");
			long an = Convert.ToInt64(Console.ReadLine());

			Console.WriteLine("Entere minutes used during daytime hours (6am to 6pm): ");
			int dm = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Entere minutes used during nighttime hours (6pm to 6am): ");
			int nm = Convert.ToInt32(Console.ReadLine());

			int tm = dm + nm;

			string R = "Regular";
			string P = "Premium";

			Console.WriteLine("Enter service type (Regular or Premium): ");
			string st = Convert.ToString(Console.ReadLine());

			Console.WriteLine("Account Number: " + an);


			float due = 0;
			float dc = 0, nc = 0;

			if (st == R)
			{
				Console.WriteLine("Service type: Regular");
				{
					if (tm <= 50)
					{
						due = 15.00f;
						Console.WriteLine("Total minutes: " + tm);
						Console.WriteLine("Amount due: $" + due);
					}
					else
					{
						due = 15.00f + ((tm - 50) * 0.50f);
						Console.WriteLine("Total minutes:" + tm);
						Console.WriteLine("Amount due: $" + due);
					}
				}
			}
			else if (st == P)
			{
				Console.WriteLine("Service type: Premium");
				Console.WriteLine("Daytime minutes: " + dm);
				Console.WriteLine("Nighttime minutes: " + nm);
				{
					if (dm > 50)
					{
						dc = ((dm - 50) * 0.20f);
					}
					else
					{
						dc = 0;
					}
					if (nm > 100)
					{
						nc = ((nm - 100) * 0.10f);
					}
					else
					{
						nc = 0;
					}
					if (dc + nc == 0)
					{
						due = 25.00f;
						Console.WriteLine("Amount due: $" + due);
					}
					else
					{
						due = (25.00f + (dc + nc));
						Console.WriteLine("Amount due: $" + due);
					}
				}
			}
				
			Console.ReadLine();
		}
	}
}

