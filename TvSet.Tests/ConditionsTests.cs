using NUnit.Framework;
using System.Windows.Shapes;
using System.Threading;

namespace TvSet.Tests
{
	public class ConditionsTests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		[Apartment(ApartmentState.STA)]
		public void CheckConditionTest()
		{

			int temp = 30;
			int hum = 60;
			Check_condition(temp,hum);

			StringAssert.Contains("Tree", result.Name);

		}
	}
}