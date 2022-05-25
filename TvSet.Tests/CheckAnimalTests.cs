using NUnit.Framework;
using System.Windows.Shapes;
using System.Threading;
using System.Windows.Media;

namespace TvSet.Tests
{
	public class CheckAnimalTests
	{

		[SetUp]

		public void Setup()
		{

		}

		[Test]
		[Apartment(ApartmentState.STA)]
		public void Check_Wolf_Test()
		{
			Rectangle obj = new Rectangle();
			var animal = new Wolf();
			int temp = 45, hum = 90;

			var result = animal.CheckCondition(temp, hum);
			StringAssert.Contains("Волк мертв", result.Item1);
			Assert.That(Brushes.Red == result.Item2);
		}
		[Test]
		[Apartment(ApartmentState.STA)]
		public void Check_Squirrel_Test()
		{
			Rectangle obj = new Rectangle();
			var animal = new Squirrel();
			int temp = -49, hum = 90;

			var result = animal.CheckCondition(temp, hum);
			StringAssert.Contains("Белка мертва", result.Item1);
			Assert.That(Brushes.Red == result.Item2);
		}
		[Test]
		[Apartment(ApartmentState.STA)]
		public void Check_Fox_Test()
		{
			Rectangle obj = new Rectangle();
			var animal = new Fox();
			int temp = -49, hum = 90;

			var result = animal.CheckCondition(temp, hum);
			StringAssert.Contains("Лиса мертва", result.Item1);
			Assert.That(Brushes.Red == result.Item2);
		}
		[Test]
		[Apartment(ApartmentState.STA)]
		public void Check_Bear_Test()
		{
			Rectangle obj = new Rectangle();
			var animal = new Bear();
			int temp = -49, hum = 5;

			var result = animal.CheckCondition(temp, hum);
			StringAssert.Contains("Медведь мертв", result.Item1);
			Assert.That(Brushes.Red == result.Item2);
		}
		[Test]
		[Apartment(ApartmentState.STA)]
		public void Check_Bunny_Test()
		{
			Rectangle obj = new Rectangle();
			var animal = new Bunny();
			int temp = 49, hum = 85;

			var result = animal.CheckCondition(temp, hum);
			StringAssert.Contains("Зайчик мертв", result.Item1);
			Assert.That(Brushes.Red == result.Item2);
		}

	}
}