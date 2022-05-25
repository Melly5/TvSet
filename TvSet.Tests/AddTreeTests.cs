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
		public void Add_Fir_Test()
		{
			Rectangle obj = new Rectangle();
			var tree = new Fir();
			var result = tree.Add(obj);
			StringAssert.Contains("Tree", result.Name);
			Assert.AreEqual(120, result.Height);
			Assert.AreEqual(120, result.Width);
			Assert.AreEqual(0, result.Tag);
		}
		[Test]
		[Apartment(ApartmentState.STA)]
		public void Add_DregonTree_Test()
		{
			Rectangle obj = new Rectangle();
			var tree = new DragonTree();
			var result = tree.Add(obj);
			StringAssert.Contains("Tree", result.Name);
			Assert.AreEqual(120, result.Height);
			Assert.AreEqual(140, result.Width);
			Assert.AreEqual(1, result.Tag);
		}
		[Test]
		[Apartment(ApartmentState.STA)]
		public void Add_Beech_Test()
		{
			Rectangle obj = new Rectangle();
			var tree = new Beech();
			var result = tree.Add(obj);
			StringAssert.Contains("Tree", result.Name);
			Assert.AreEqual(150, result.Height);
			Assert.AreEqual(120, result.Width);
			Assert.AreEqual(2, result.Tag);
		}
		[Test]
		[Apartment(ApartmentState.STA)]
		public void Add_Linden_Test()
		{
			Rectangle obj = new Rectangle();
			var tree = new Linden();
			var result = tree.Add(obj);
			StringAssert.Contains("Tree", result.Name);
			Assert.AreEqual(150, result.Height);
			Assert.AreEqual(120, result.Width);
			Assert.AreEqual(3, result.Tag);
		}
		[Test]
		[Apartment(ApartmentState.STA)]
		public void Add_Oak_Test()
		{
			Rectangle obj = new Rectangle();
			var tree = new Oak();
			var result = tree.Add(obj);
			StringAssert.Contains("Tree", result.Name);
			Assert.AreEqual(130, result.Height);
			Assert.AreEqual(140, result.Width);
			Assert.AreEqual(4, result.Tag);
		}
	}
}
