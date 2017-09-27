using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Street.Library.Common;
using Street.Library.Story1;

namespace Street.Tests.Story1
{
	[TestClass]
	public class TownPlannerStreetTrackerTests
	{
		[TestMethod]
		public void IsValidStreetTest()
		{
			IStreetSpecifications specficationTest1 = new FileStreetSpecifications("13245.txt");

			TownPlannerStreetTracker test = new TownPlannerStreetTracker(specficationTest1);

			Assert.IsTrue(test.IsValidStreet());
			Assert.IsTrue(test.IsValidStreet());

			specficationTest1 = new FileStreetSpecifications("Street1.txt");

			test = new TownPlannerStreetTracker(specficationTest1);
			Assert.IsTrue(test.IsValidStreet());

			specficationTest1 = new FileStreetSpecifications("Invalid1.txt");

			test = new TownPlannerStreetTracker(specficationTest1);
			Assert.IsFalse(test.IsValidStreet());

			specficationTest1 = new FileStreetSpecifications("Invalid2.txt");

			test = new TownPlannerStreetTracker(specficationTest1);
			Assert.IsFalse(test.IsValidStreet());
		}

		[TestMethod]
		public void NumberOfHousesTest()
		{
			IStreetSpecifications specficationTest1 = new FileStreetSpecifications("13245.txt");

			TownPlannerStreetTracker test = new TownPlannerStreetTracker(specficationTest1);
			Assert.AreEqual(5, test.NumberOfHouses());

			specficationTest1 = new FileStreetSpecifications("Street1.txt");

			test = new TownPlannerStreetTracker(specficationTest1);
			Assert.AreEqual(14, test.NumberOfHouses());

			specficationTest1 = new FileStreetSpecifications("Invalid1.txt");

			test = new TownPlannerStreetTracker(specficationTest1);

			try
			{
				test.NumberOfHouses();
				Assert.Fail("Must throw exception");
			}
			catch (Exception)
			{
			    // ignored
			}

		    specficationTest1 = new FileStreetSpecifications("Invalid1.txt");

			test = new TownPlannerStreetTracker(specficationTest1);

			try
			{
				test.NumberOfHouses();
				Assert.Fail("Must throw exception");
			}
			catch (Exception)
			{
			    // ignored
			}
		}

		[TestMethod]
		public void NumberOfNorthHousesTest()
		{
			IStreetSpecifications specficationTest1 = new FileStreetSpecifications("13245.txt");

			TownPlannerStreetTracker test = new TownPlannerStreetTracker(specficationTest1);
			Assert.AreEqual(3, test.NumberOfNorthHouses());

			specficationTest1 = new FileStreetSpecifications("Street1.txt");

			test = new TownPlannerStreetTracker(specficationTest1);
			Assert.AreEqual(8, test.NumberOfNorthHouses());

			specficationTest1 = new FileStreetSpecifications("Invalid1.txt");

			test = new TownPlannerStreetTracker(specficationTest1);

			try
			{
				test.NumberOfNorthHouses();
				Assert.Fail("Must throw exception");
			}
			catch (Exception)
			{
			    // ignored
			}

		    specficationTest1 = new FileStreetSpecifications("Invalid1.txt");

			test = new TownPlannerStreetTracker(specficationTest1);

			try
			{
				test.NumberOfNorthHouses();
				Assert.Fail("Must throw exception");
			}
			catch (Exception)
			{
			    // ignored
			}
		}

		[TestMethod]
		public void NumberOfSouthHousesTest()
		{
			IStreetSpecifications specficationTest1 = new FileStreetSpecifications("13245.txt");

			TownPlannerStreetTracker test = new TownPlannerStreetTracker(specficationTest1);
			Assert.AreEqual(2, test.NumberOfSouthHouses());

			specficationTest1 = new FileStreetSpecifications("Street1.txt");

			test = new TownPlannerStreetTracker(specficationTest1);
			Assert.AreEqual(6, test.NumberOfSouthHouses());

			specficationTest1 = new FileStreetSpecifications("Invalid1.txt");

			test = new TownPlannerStreetTracker(specficationTest1);
			try
			{
				test.NumberOfSouthHouses();
				Assert.Fail("Must throw exception");
			}
			catch (Exception)
			{
			    // ignored
			}

		    specficationTest1 = new FileStreetSpecifications("Invalid1.txt");

			test = new TownPlannerStreetTracker(specficationTest1);

			try
			{
				test.NumberOfSouthHouses();
				Assert.Fail("Must throw exception");
			}
			catch (Exception)
			{
			    // ignored
			}
		}

	}
}
