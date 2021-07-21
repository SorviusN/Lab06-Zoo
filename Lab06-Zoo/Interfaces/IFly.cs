using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_Zoo.Interfaces
{
	interface IFly // Creating an interface that can be used across all of the classes.
	{
		string AverageAltitude { get; set; }

		void Land();

		string TakeOff();

		void Perch();
	}
}
