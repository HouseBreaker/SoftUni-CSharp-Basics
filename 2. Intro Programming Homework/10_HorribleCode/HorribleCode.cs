﻿using System;

class HorribleCode
{
	static void Main()
	{
		Console.WriteLine("Hi, I am horribly formatted program");
		Console.WriteLine("Numbers and squares:");

		for (int i = 0; i < 1000; i++)
		{
			Console.WriteLine(i + " --> " + i * i);
		}
	}
}
