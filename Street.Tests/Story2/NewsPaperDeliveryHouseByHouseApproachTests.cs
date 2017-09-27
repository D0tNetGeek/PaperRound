using Microsoft.VisualStudio.TestTools.UnitTesting;
using Street.Library.Common;
using Street.Library.Story2;

namespace Street.Tests.Story2
{
	[TestClass]
	public class NewsPaperDeliveryHouseByHouseApproachTests
	{
		[TestMethod]
		public void GetCrossingStreetNumberTest()
		{
			IStreetSpecifications specficationTest1 = new FileStreetSpecifications("13245.txt");
			NewsPaperDeliveryHouseByHouseApproach test = new NewsPaperDeliveryHouseByHouseApproach(specficationTest1);
			
			Assert.AreEqual(2, test.GetCrossingStreetNumber());
			specficationTest1 = new FileStreetSpecifications("Street1.txt");

			test = new NewsPaperDeliveryHouseByHouseApproach(specficationTest1);
			Assert.AreEqual(8, test.GetCrossingStreetNumber());
		}

		[TestMethod]
		public void GetNewsPapersDeliveryOrderTest()
		{
			IStreetSpecifications specficationTest1 = new FileStreetSpecifications("13245.txt");
			NewsPaperDeliveryHouseByHouseApproach test = new NewsPaperDeliveryHouseByHouseApproach(specficationTest1);

			int[] expected = { 1, 3, 2, 4, 5 };
			int[] actual = test.GetNewsPapersDeliveryOrder();

			Assert.AreEqual(expected.Length, actual.Length);

			for (int i = 0; i < expected.Length; i++)
			{
				Assert.AreEqual(expected[i], actual[i]);
			}

			specficationTest1 = new FileStreetSpecifications("Street1.txt");
			test = new NewsPaperDeliveryHouseByHouseApproach(specficationTest1);

			expected = new[] { 1, 2, 4, 3, 6, 5, 7, 8, 9, 10, 12, 11, 13, 15 };
			actual = test.GetNewsPapersDeliveryOrder();

			Assert.AreEqual(expected.Length, actual.Length);

			for (int i = 0; i < expected.Length; i++)
			{
				Assert.AreEqual(expected[i], actual[i]);
			}
		}
	}
}
