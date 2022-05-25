using NUnit.Framework;
using System.Windows.Shapes;
using System.Threading;

namespace TvSet.Tests
{
	public class AddTreeTests
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
			var tree = new Tree();
			int ind = 1;
			var result = tree.AddTree(obj, ind);
			StringAssert.Contains("Tree", result.Name);
			Assert.AreEqual(120, result.Height);
			Assert.AreEqual(120, result.Width);
			Assert.AreEqual(0, result.Tag);
		}
	}
}
