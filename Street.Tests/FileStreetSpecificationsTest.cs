using Microsoft.VisualStudio.TestTools.UnitTesting;
using Street.Library.Common;

namespace Street.Tests
{
	[TestClass]
	public class FileStreetSpecificationsTest
	{
		[TestMethod]
		public void TestGetStreetHouses()
		{
			FileStreetSpecifications test = new FileStreetSpecifications("13245.txt");
			Assert.AreEqual(5, test.GetStreetHouses().Length);
			Assert.AreEqual(5, test.GetStreetHouses().Length);

			test = new FileStreetSpecifications("Street1.txt");
			Assert.AreEqual(14, test.GetStreetHouses().Length);

			test = new FileStreetSpecifications("Invalid1.txt");
			Assert.AreEqual(8, test.GetStreetHouses().Length);
		}
	}
}
