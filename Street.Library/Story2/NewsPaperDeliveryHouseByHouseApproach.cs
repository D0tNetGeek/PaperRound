using Street.Library.Common;

namespace Street.Library.Story2
{
	public class NewsPaperDeliveryHouseByHouseApproach:StreetOperation, INewsPaperDeliveryOrder, INewsPaparsDeliveryStreetCrossing
	{
		public NewsPaperDeliveryHouseByHouseApproach(IStreetSpecifications streetSpecifications):base(streetSpecifications)
		{
		}
		public int GetCrossingStreetNumber()
		{
			bool isNorth = true;

			int result = 0;

			var street = GetStreetHouses();

			foreach (int t in street)
			{
			    if (t % 2 == 0 && isNorth || t % 2 != 0 && !isNorth)
			    {
			        result++;
			        isNorth = !isNorth;
			    }
			}

		    return result;
		}

		public int[] GetNewsPapersDeliveryOrder()
		{
			return GetStreetHouses();
		}
	}
}
