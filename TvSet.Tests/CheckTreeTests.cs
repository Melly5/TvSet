using NUnit.Framework;
using System.Windows.Shapes;
using System.Threading;
using System.Windows.Media;

namespace TvSet.Tests
{
	public class CheckTreeTests
	{

		[SetUp]

		public void Setup()
		{

		}

		[Test]
		[Apartment(ApartmentState.STA)]
		public void Check_Fir_Test()
		{
			Rectangle obj = new Rectangle();
			var tree = new Fir();
			int temp = -45, hum = 5;

			var result = tree.CheckCondition(temp, hum);
			StringAssert.Contains("Ваше дерево мертво", result.Item1);
			Assert.That(Brushes.Red == result.Item2);
		}
		[Test]
		[Apartment(ApartmentState.STA)]
		public void Check_DragonTree_Test()
		{
			Rectangle obj = new Rectangle();
			var tree = new DragonTree();
			int temp = -45, hum = 30;

			var result = tree.CheckCondition(temp, hum);
			StringAssert.Contains("Ваше дерево мертво", result.Item1);
			Assert.That(Brushes.Red == result.Item2);
		}
		[Test]
		[Apartment(ApartmentState.STA)]
		public void Check_Beech_Test()
		{
			Rectangle obj = new Rectangle();
			var tree = new Beech();
			int temp = -49, hum = 30;

			var result = tree.CheckCondition(temp, hum);
			StringAssert.Contains("Ваше дерево мертво", result.Item1);
			Assert.That(Brushes.Red == result.Item2);
		}
		[Test]
		[Apartment(ApartmentState.STA)]
		public void Check_Linden_Test()
		{
			Rectangle obj = new Rectangle();
			var tree = new Linden();
			int temp = -49, hum = 30;

			var result = tree.CheckCondition(temp, hum);
			StringAssert.Contains("Ваше дерево мертво", result.Item1);
			Assert.That(Brushes.Red == result.Item2);
		}
		[Test]
		[Apartment(ApartmentState.STA)]
		public void Check_Oak_Test()
		{
			Rectangle obj = new Rectangle();
			var tree = new Oak();
			int temp = -45, hum = 30;

			var result = tree.CheckCondition(temp, hum);
			StringAssert.Contains("Ваше дерево мертво", result.Item1);
			Assert.That(Brushes.Red == result.Item2);
		}

	}
}