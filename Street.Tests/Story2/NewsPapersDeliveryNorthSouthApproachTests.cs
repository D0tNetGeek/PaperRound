using Microsoft.VisualStudio.TestTools.UnitTesting;
using Street.Library.Common;
using Street.Library.Story2;

namespace Street.Tests.Story2
{
	[TestClass]
	public class NewsPapersDeliveryNorthSouthApproachTests
	{
		[TestMethod]
		public void GetNewsPapersDeliveryOrderTest()
		{
			IStreetSpecifications specficationTest1 = new FileStreetSpecifications("13245.txt");
			NewsPapersDeliveryNorthSouthApproach test = new NewsPapersDeliveryNorthSouthApproach(specficationTest1);

			int[] expected = { 1, 3, 5, 4, 2 };
			int[] actual = test.GetNewsPapersDeliveryOrder();

			Assert.AreEqual(expected.Length, actual.Length);

			for (int i = 0; i < expected.Length; i++)
			{
				Assert.AreEqual(expected[i], actual[i]);
			}

			specficationTest1 = new FileStreetSpecifications("Street1.txt");
			test = new NewsPapersDeliveryNorthSouthApproach(specficationTest1);

			expected = new[] { 1, 3, 5, 7, 9, 11, 13, 15, 12, 10, 8, 6, 4 ,2 };
			actual = test.GetNewsPapersDeliveryOrder();

			Assert.AreEqual(expected.Length, actual.Length);

			for (int i = 0; i < expected.Length; i++)
			{
				Assert.AreEqual(expected[i], actual[i]);
			}
		}
	}
}
