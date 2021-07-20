using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_Zoo.Classes
{
	class Wolf : LandAnimal
	{

		public override string Name { get; set; } = "Wolf";

		public override void Movement()
		{
			Console.WriteLine($"The {Name} walks on {Legs} legs.");
		}

		public override void Sound()
		{
			Console.WriteLine($"The {Name} howls at the moon");
		}
	}

}
