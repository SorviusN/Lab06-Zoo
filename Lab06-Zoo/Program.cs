using System;
using Lab06_Zoo.Classes;

namespace Lab06_Zoo
{
	class Program
	{
		static void Main(string[] args)
		{
			// Creating an instance of a wolf class 
			Wolf wolf = new Wolf();
			wolf.Movement();
			wolf.Sound();

			Snake snek = new Snake();
			snek.Sound();

			Dolphin dolphin = new Dolphin();
			dolphin.Sound();

			Crab crab = new Crab();
			crab.Sound();

			Birb birb = new Birb();
			birb.Sound();
			birb.Sleep();

		}
	}
}
