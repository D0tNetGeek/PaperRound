using System.Linq;
using Street.Library.Common;
using Street.Library.Story1;
using Street.Library.Story2;

namespace Street.Console
{
    static class Program
	{
		static void Main()
		{
			IStreetSpecifications streetSpecifications = new FileStreetSpecifications("Street1.txt");
			IStreetTracker defaultTracker = new TownPlannerStreetTracker(streetSpecifications);

            System.Console.WriteLine("Story 1");
            System.Console.WriteLine("-------\n");

            var isFileValid = defaultTracker.IsValidStreet()
		        ? "The Specifications are valid."
		        : "The Specifications are not valid.";

		    System.Console.WriteLine("Acceptance Criteria 1: " + isFileValid + "\n");

		    System.Console.WriteLine("Acceptance Criteria 2: The number of houses in a given street are : " + defaultTracker.NumberOfHouses());

            System.Console.WriteLine("\nAcceptance Criteria 3: The number of houses on the left hand (north) side of the street are : " + defaultTracker.NumberOfNorthHouses());
            System.Console.WriteLine("\nAcceptance Criteria 4: The number of houses on the right hand (south) side of the street are : " + defaultTracker.NumberOfSouthHouses());

            System.Console.WriteLine("\n-------------------------------------------------------------------------------\n");

			System.Console.WriteLine("Story 2");
            System.Console.WriteLine("-------\n");

            NewsPapersDeliveryNorthSouthApproach delivery1 = new NewsPapersDeliveryNorthSouthApproach(streetSpecifications);

            NewsPaperDeliveryHouseByHouseApproach delivery2 = new NewsPaperDeliveryHouseByHouseApproach(streetSpecifications);

		    System.Console.WriteLine(
		        "\nAcceptance Criteria 5: The list of house numbers in the order that I will be delivering to, so that I can sort by satchel in advance are :" +
		        delivery1.GetNewsPapersDeliveryOrder().Aggregate("\n\t", (rslt, x) => rslt + " " + x, x => x));

            System.Console.WriteLine(delivery2.GetNewsPapersDeliveryOrder().Aggregate("\t", (rslt, x) => rslt + " " + x, x => x));

			System.Console.WriteLine("\nAcceptance Criteria 6: (" + delivery2.GetCrossingStreetNumber() + ") times I will have to cross the road from one side to the other to make my deliveries");

            System.Console.ReadKey();
		}
	}
}
