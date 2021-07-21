using System;
using Xunit;
using Lab06_Zoo.Classes;

namespace ZooTests
{
	public class UnitTest1
	{
		[Fact]
		public void CanMakeSound()
		{
			// the Sound() method comes from the god class of animals and is
			//overridden to out put a sounds unique to an Eagle.
			Eagle eagle = new Eagle();
			Assert.Equal($"The {eagle.Name} chirps and whistles a song", eagle.Sound());
		}

		[Fact]
		public void UsingInterface()
		{
			Eagle eagle = new Eagle();
			Assert.Equal($"The eagle takes off to fly. Its average altitude is {eagle.AverageAltitude}", eagle.TakeOff());
		}
	}
}
