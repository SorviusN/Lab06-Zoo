using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_Zoo.Classes
{
	class Dolphin : AquaticAnimal
	{
		public override bool HasShell { get; set; } = false;

		public override string Name { get; set; } = "Dolphin";

		public override void Movement()
		{
			Console.WriteLine($"The {Name} is swimming");
		}

		public override string Sound()
		{
			return ($"The {Name} is calling and has {Fins} fins.");
		}
	}
}
