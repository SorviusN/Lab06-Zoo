using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab06_Zoo.Interfaces;

namespace Lab06_Zoo.Classes
{
	class Wolf : LandAnimal, IPredator
	{

		public override string Name { get; set; } = "Wolf";

		public void Kill()
		{
			Console.WriteLine($" The {Name} kills its prey.");
		}

		public override void Movement()
		{
			Console.WriteLine($"The {Name} walks on {Legs} legs.");
		}

		public override string Sound()
		{
			return ($"The {Name} howls at the moon");
		}

		public void stalkPrey()
		{
			Console.WriteLine($"The {Name} is stalking its prey.");
		}
	}

}
