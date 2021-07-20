using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_Zoo.Classes
{
	class Crab : AquaticAnimal
	{
		public override string Name { get; set; } = "Hermit Crab";
		public override bool HasShell { get; set; } = true;
		public override void Movement()
		{
			Console.WriteLine($"The {Name} scuttles across the sea floor.");
		}
		public override void Sound()
		{
			Console.WriteLine($"The {Name} chirps like a cricket.");
		}
	}
}
