using NUnit.Framework;
using System.Windows.Shapes;
using System.Windows;
using System.Windows.Threading;
using TvSet;
using System.Threading;

namespace TvSet.Tests
{
	public class AddAnimalTests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		[Apartment(ApartmentState.STA)]
		public void CheckNameTest()
		{
			Rectangle obj = new Rectangle();
			var animal = new Animal();
			int ind = 1;
			var result = animal.AddAnimal(obj, ind);
			StringAssert.Contains("Animal", result.Name);
			Assert.AreEqual(80, result.Height);
			Assert.AreEqual(115, result.Width);
			Assert.AreEqual(0, result.Tag);
		}
		

		

	}
}
