using System;
using Lab06_Zoo.Classes;
using Lab06_Zoo.Interfaces;

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
			wolf.stalkPrey();

			Snake snek = new Snake();
			snek.Sound();

			Dolphin dolphin = new Dolphin();
			dolphin.Sound();

			Crab crab = new Crab();
			crab.Sound();

			Eagle birb = new Eagle();
			birb.Sound();
			birb.Sleep();

		}
	}
}
