using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_Zoo.Classes
{
	abstract public class Animal //God Class
	{
		// The name of animal
		public abstract string Name { get; set; }

		// virtual class because we define it here and it can be passed down to children. 
		public virtual void Eat() {
			Console.WriteLine($"The {Name} is eating.");
		}
		public virtual void Sleep() {
			Console.WriteLine($"The {Name} is sleeping.");
		}
		public virtual void Reproduction() {
			Console.WriteLine($" The {Name} is reproducing.");
		}

		// Must be defined in child classes ( Necessary property).
		public abstract void Sound();

		public abstract void Movement(); //this could also be a prop.

	}
}
