using System;
using System.Linq;
using Street.Library.Common;

namespace Street.Library.Story1
{
	public class TownPlannerStreetTracker: StreetOperation, IStreetTracker
	{
		public TownPlannerStreetTracker(IStreetSpecifications streetSpecifications):base(streetSpecifications)
		{
		}

		private bool? _isValid;

	    public bool IsValidStreet()
	    {
	        if (_isValid != null)
	            return _isValid.Value;

	        var north = GetStreetHouses().Where(x => x%2 == 1).ToArray();
	        var south = GetStreetHouses().Where(x => x%2 == 0).ToArray();

	        for (int i = 0; i < north.Length; i++)
	            if (north[i] != i*2 + 1)
	            {
	                _isValid = false;
	                return _isValid.Value;
	            }

	        for (int i = 0; i < south.Length; i++)
	            if (south[i] != i*2 + 2)
	            {
	                _isValid = false;
	                return _isValid.Value;
	            }

	        _isValid = true;

	        return _isValid.Value;
	    }

	    public int NumberOfHouses()
		{
			if (!IsValidStreet())
				throw new InvalidOperationException("Can't calculate the number of streets if the street specification is invalid");

			return GetStreetHouses().Length;
		}

		public int NumberOfNorthHouses()
		{
			if (!IsValidStreet())
				throw new InvalidOperationException("Can't calculate the number of streets if the street specification is invalid");

			return GetStreetHouses().Count(x => x % 2 == 1);
		}

		public int NumberOfSouthHouses()
		{
			if (!IsValidStreet())
				throw new InvalidOperationException("Can't calculate the number of streets if the street specification is invalid");
			return GetStreetHouses().Count(x => x % 2 == 0);
		}

	}
}
