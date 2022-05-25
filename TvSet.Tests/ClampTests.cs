using NUnit.Framework;
using System.Threading;


namespace TvSet.Tests
{
	public class ClampTests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		[Apartment(ApartmentState.STA)]
		public void Clamp_Min_Test()
		{
			var clamp = new Clamp_Move();
			Assert.That(clamp.Clamp(3, 4, 5) == 4);
			
		}
		[Test]
		[Apartment(ApartmentState.STA)]
		public void Clamp_Max_Test()
		{
			var clamp = new Clamp_Move();
			Assert.That(clamp.Clamp(7, 4, 5) == 5);

		}
		[Test]
		[Apartment(ApartmentState.STA)]
		public void Clamp_Between_Test()
		{
			var clamp = new Clamp_Move();
			Assert.That(clamp.Clamp(4, 3, 5) == 4);

		}
	}
}