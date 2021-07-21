using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_Zoo.Interfaces
{
	interface IFly
	{
		string AverageAltitude { get; set; }

		void Land();

		void TakeOff();

		void Perch();
	}
}
