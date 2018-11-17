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
//Lab: 11

namespace Lab11_Radio
{
	class TestRadio
	{
		static void Main(String[] args)
		{
			Radio r = new Radio();

			Console.WriteLine("Turn radio on:");
			r.TurnOn();
			Console.WriteLine(r.ToString());
			Console.WriteLine();

			Console.WriteLine("Turn volume up by 3:");
			r.TurnOn();
			r.VolumeUp(3);
			Console.WriteLine(r.ToString());
			Console.WriteLine();

			Console.WriteLine("Move station up by 5:");
			r.TurnOn();
			r.StationUp(5);
			Console.WriteLine(r.ToString());
			Console.WriteLine();

			Console.WriteLine("Turn volume down by 1:");
			r.TurnOn();
			r.VolumeDown(1);
			Console.WriteLine(r.ToString());
			Console.WriteLine();


			Console.WriteLine("Move station up by 3:");
			r.TurnOn();
			r.StationUp(3);
			Console.WriteLine(r.ToString());
			Console.WriteLine();

			Console.WriteLine("Turn radio off.");
			r.TurnOff();
			Console.WriteLine(r.ToString());
			Console.WriteLine();

			Console.WriteLine("Turn volume up by 2.");
			r.TurnOff();
			Console.WriteLine(r.ToString());
			Console.WriteLine();

			Console.WriteLine("Turn station down by 2.");
			r.TurnOff();
			Console.WriteLine(r.ToString());
			Console.WriteLine();

			Console.ReadLine();

		}
	}
}
