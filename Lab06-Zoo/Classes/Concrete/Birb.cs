using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_Zoo.Classes
{
	class Birb : AvianAnimal
	{
		public override string Name { get; set; } = "Birb";
		public override void Movement()
		{
			Console.WriteLine($"The {Name} glides through the air with its {Wings} wings.");
		}
		public override void Sound()
		{
			Console.WriteLine($"The {Name} chirps and whistles a song");
		}
	}
}
