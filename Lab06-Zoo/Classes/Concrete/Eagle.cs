using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab06_Zoo.Interfaces;

namespace Lab06_Zoo.Classes
{
	public class Eagle : AvianAnimal, IPredator, IFly
	{
		public override string Name { get; set; } = "Birb";
		public string AverageAltitude { get; set; } = "High";

		public void Kill()
		{
			Console.WriteLine("The Eagle hunts and kills a fish because it has the IPredator interface.");
		}

		public void Land()
		{
			Console.WriteLine("The Eagle lands because it has the IFLy interface.");
		}

		public override void Movement()
		{
			Console.WriteLine($"The {Name} glides through the air with its {Wings} wings.");
		}

		public void Perch()
		{
			Console.WriteLine("The Eagle perches on its roost.");
		}

		public override string Sound()
		{
			return($"The {Name} chirps and whistles a song");
		}

		public void stalkPrey()
		{
			Console.WriteLine("The eagle stalks its prey (fish) before eating.");
		}

		public string TakeOff()
		{
			return ($"The eagle takes off to fly. Its average altitude is {AverageAltitude}");
		}
	}
}
