using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_Zoo.Classes
{
	public abstract class AvianAnimal : Animal
	{
		public override string Name { get; set; } = "Avian Animal";
		public virtual int Wings { get; set; } = 2;
		public override abstract void Movement();
		public override abstract string Sound();

		public virtual bool IsNocturnal { get; set; } = false;
	}
}
