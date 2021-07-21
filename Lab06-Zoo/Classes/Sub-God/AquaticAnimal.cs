using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_Zoo.Classes
{
	public abstract class AquaticAnimal : Animal
	{
		public virtual int Fins { get; set; } = 2;
		public override string Name { get; set; } = "Aquatic Animal";

		public override abstract void Movement();

		public override abstract string Sound();

		public abstract bool HasShell { get; set; }
	}
}
