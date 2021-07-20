using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_Zoo.Classes
{
	// Child of god class
	abstract class LandAnimal : Animal
	{
		// We are overriding the Animal props Name (Not defined yet) to make a custom Name.
		public override string Name { get; set; } = "Land Animal";

		// Setting an integer that is defined in this class. Can be changed later.
		public virtual int Legs { get; set; } = 4;

		// we use override and abstract together in methods to pass them down and not define them.
		public override abstract void Movement(); 
		public override abstract void Sound();

	}
}
