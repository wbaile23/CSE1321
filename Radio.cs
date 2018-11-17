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
	class Radio
	{
		private int station = 1;
		private int volume = 1;
		private bool on = false;

		public Radio()
		{
		}
		public Radio(int newStation, int newVolume, bool newOn)
		{
			station = newStation;
			volume = newVolume;
			on = newOn;
		}
		public int getStation()
		{
			return station;
		}
		public int getVolume()
		{
			return volume;
		}
		public bool TurnOn()
		{
			return on = true;
		}
		public bool TurnOff()
		{
			return on = false;
		}
		public int StationUp(int s)
		{
			if (on == true)
			{
				station = station + s;
			}
			return station;
		}
		public int StationDown(int s)
		{
			if (on == true)
			{
				station = station - s;
			}
			return station;
		}
		public int VolumeUp(int v)
		{
			if (on == true)
			{
				volume = volume + v;
			}
			return volume;
		}
		public int VolumeDown(int v)
		{
			if (on == true)
			{
				volume = volume - v;
			}
			return volume;
		}
		public override string ToString()
		{

			if (on == true)
			{
				return "\tThe radio station is " + station + " and the volume level is " + volume + ".";
			}

			else
			{
				return "\tThe radio is off.";
			}

			
		}
	}
}
