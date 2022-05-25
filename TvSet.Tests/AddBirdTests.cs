using NUnit.Framework;
using System.Windows.Shapes;
using System.Threading;

namespace TvSet.Tests
{
	public class AddBirdTests
	{
		
		[SetUp]

		public void Setup()
		{

		}

		[Test]
		[Apartment(ApartmentState.STA)]
		public void Add_Redpoll_Test()
		{
			Rectangle obj = new Rectangle();
			var bird = new Redpoll();			
			var result = bird.Add(obj);
			StringAssert.Contains("Bird", result.Name);
			Assert.AreEqual(60, result.Height);
			Assert.AreEqual(60, result.Width);
			Assert.AreEqual(0, result.Tag);
		}
		[Test]
		[Apartment(ApartmentState.STA)]
		public void Add_BlueTit_Test()
		{
			Rectangle obj = new Rectangle();
			var bird = new BlueTit();
			var result = bird.Add(obj);
			StringAssert.Contains("Bird", result.Name);
			Assert.AreEqual(50, result.Height);
			Assert.AreEqual(60, result.Width);
			Assert.AreEqual(1, result.Tag);
		}
		[Test]
		[Apartment(ApartmentState.STA)]
		public void Add_Pigeon_Test()
		{
			Rectangle obj = new Rectangle();
			var bird = new Pigeon();
			var result = bird.Add(obj);
			StringAssert.Contains("Bird", result.Name);
			Assert.AreEqual(70, result.Height);
			Assert.AreEqual(70, result.Width);
			Assert.AreEqual(2, result.Tag);
		}
		[Test]
		[Apartment(ApartmentState.STA)]
		public void Add_Hummingbird_Test()
		{
			Rectangle obj = new Rectangle();
			var bird = new Hummingbird();
			var result = bird.Add(obj);
			StringAssert.Contains("Bird", result.Name);
			Assert.AreEqual(50, result.Height);
			Assert.AreEqual(50, result.Width);
			Assert.AreEqual(3, result.Tag);
		}
		[Test]
		[Apartment(ApartmentState.STA)]
		public void Add_Finch_Test()
		{
			Rectangle obj = new Rectangle();
			var bird = new Finch();
			var result = bird.Add(obj);
			StringAssert.Contains("Bird", result.Name);
			Assert.AreEqual(60, result.Height);
			Assert.AreEqual(75, result.Width);
			Assert.AreEqual(4, result.Tag);
		}

	}
}