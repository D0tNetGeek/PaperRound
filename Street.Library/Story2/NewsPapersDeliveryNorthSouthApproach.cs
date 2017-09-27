using System.Linq;
using Street.Library.Common;

namespace Street.Library.Story2
{
	public class NewsPapersDeliveryNorthSouthApproach:StreetOperation, INewsPaperDeliveryOrder
	{
	    public NewsPapersDeliveryNorthSouthApproach(IStreetSpecifications streetSpecifications):base(streetSpecifications)
		{
		}

		public int[] GetNewsPapersDeliveryOrder()
		{
			var result= GetStreetHouses().Where(x => x % 2 == 1).ToList();

			result.AddRange(GetStreetHouses().Where(x => x % 2 == 0).Reverse());

			return result.ToArray();
		}
	}
}
