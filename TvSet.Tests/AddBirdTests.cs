using NUnit.Framework;
using System.Windows.Shapes;
using System.Windows;
using System.Windows.Threading;
using TvSet;
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
		public void CheckNameTest()
		{
			Rectangle obj = new Rectangle();
			var bird = new Bird();
			int ind = 1;
			var result = bird.AddBird(obj,ind);
			StringAssert.Contains("Bird", result.Name);					
		}
		[Test]
		[Apartment(ApartmentState.STA)]
		public void CheckSizeTest()
		{
			Rectangle obj = new Rectangle();
			var bird = new Bird();
			int ind = 1;
			var result = bird.AddBird(obj, ind);
			Assert.AreEqual(60, result.Height);
			Assert.AreEqual(60, result.Width);
		}
		[Test]
		[Apartment(ApartmentState.STA)]
		public void CheckTagTest()
		{
			Rectangle obj = new Rectangle();
			var bird = new Bird();
			int ind = 1;
			var result = bird.AddBird(obj, ind);
			Assert.AreEqual(0, result.Tag);
			
		}

	}
}