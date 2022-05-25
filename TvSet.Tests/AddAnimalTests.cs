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
		public void Add_Wolf_Test()
		{
			Rectangle obj = new Rectangle();
			var animal = new Wolf();
			var result = animal.Add(obj);
			StringAssert.Contains("Animal", result.Name);
			Assert.AreEqual(80, result.Height);
			Assert.AreEqual(115, result.Width);
			Assert.AreEqual(0, result.Tag);
		}
		[Test]
		[Apartment(ApartmentState.STA)]
		public void Add_Squirrel_Test()
		{
			Rectangle obj = new Rectangle();
			var animal = new Squirrel();
			var result = animal.Add(obj);
			StringAssert.Contains("Animal", result.Name);
			Assert.AreEqual(60, result.Height);
			Assert.AreEqual(60, result.Width);
			Assert.AreEqual(1, result.Tag);
		}
		[Test]
		[Apartment(ApartmentState.STA)]
		public void Add_Fox_Test()
		{
			Rectangle obj = new Rectangle();
			var animal = new Fox();
			var result = animal.Add(obj);
			StringAssert.Contains("Animal", result.Name);
			Assert.AreEqual(80, result.Height);
			Assert.AreEqual(90, result.Width);
			Assert.AreEqual(2, result.Tag);
		}
		[Test]
		[Apartment(ApartmentState.STA)]
		public void Add_Bear_Test()
		{
			Rectangle obj = new Rectangle();
			var animal = new Bear();
			var result = animal.Add(obj);
			StringAssert.Contains("Animal", result.Name);
			Assert.AreEqual(130, result.Height);
			Assert.AreEqual(140, result.Width);
			Assert.AreEqual(3, result.Tag);
		}
		[Test]
		[Apartment(ApartmentState.STA)]
		public void Add_Bunny_Test()
		{
			Rectangle obj = new Rectangle();
			var animal = new Bunny();
			var result = animal.Add(obj);
			StringAssert.Contains("Animal", result.Name);
			Assert.AreEqual(60, result.Height);
			Assert.AreEqual(80, result.Width);
			Assert.AreEqual(4, result.Tag);
		}




	}
}
