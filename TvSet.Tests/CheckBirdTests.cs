using NUnit.Framework;
using System.Windows.Shapes;
using System.Threading;
using System.Windows.Media;

namespace TvSet.Tests
{
	public class CheckBirdTests
	{

		[SetUp]

		public void Setup()
		{

		}

		[Test]
		[Apartment(ApartmentState.STA)]
		public void Check_Redpoll_Test()
		{
			Rectangle obj = new Rectangle();
			var bird = new Redpoll();
			int temp = -45, hum = 30;
			
			var result = bird.CheckCondition(temp,hum);
			StringAssert.Contains("Птица мертва", result.Item1);
			Assert.That(Brushes.Red==result.Item2);
		}
		[Test]
		[Apartment(ApartmentState.STA)]
		public void Check_BlueTit_Test()
		{
			Rectangle obj = new Rectangle();
			var bird = new BlueTit();
			int temp = -45, hum = 30;

			var result = bird.CheckCondition(temp, hum);
			StringAssert.Contains("Птица мертва", result.Item1);
			Assert.That(Brushes.Red == result.Item2);
		}
		[Test]
		[Apartment(ApartmentState.STA)]
		public void Check_Pigeon_Test()
		{
			Rectangle obj = new Rectangle();
			var bird = new Pigeon();
			int temp = -49, hum = 30;

			var result = bird.CheckCondition(temp, hum);
			StringAssert.Contains("Птица мертва", result.Item1);
			Assert.That(Brushes.Red == result.Item2);
		}
		[Test]
		[Apartment(ApartmentState.STA)]
		public void Check_Hummingbird_Test()
		{
			Rectangle obj = new Rectangle();
			var bird = new Hummingbird();
			int temp = -49, hum = 30;

			var result = bird.CheckCondition(temp, hum);
			StringAssert.Contains("Птица мертва", result.Item1);
			Assert.That(Brushes.Red == result.Item2);
		}
		[Test]
		[Apartment(ApartmentState.STA)]
		public void Check_Finch_Test()
		{
			Rectangle obj = new Rectangle();
			var bird = new Finch();
			int temp = -45, hum = 30;

			var result = bird.CheckCondition(temp, hum);
			StringAssert.Contains("Птица мертва", result.Item1);
			Assert.That(Brushes.Red == result.Item2);
		}

	}
}