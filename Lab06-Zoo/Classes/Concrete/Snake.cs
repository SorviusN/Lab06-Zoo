using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_Zoo.Classes
{
	class Snake : LandAnimal
	{
		public override string Name { get; set; } = "Snake"; 

		public override void Movement()
		{
			Console.WriteLine($"The {Name} slithers on ground");
		}

		public override string Sound()
		{
			return ($"The {Name} is singing {Name} jazz");
		}
	}
}
