using NUnit.Framework;
using System.Windows.Shapes;
using TvSet;
namespace TvSetTests
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void Test1()
		{
			var obj = new Bird();
			obj.AddBird();
			Assert.Pass();
		}
	}
}