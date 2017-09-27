namespace Street.Library.Common
{
	public abstract class StreetOperation
	{
	    private IStreetSpecifications StreetSpecifications { get; set; }

	    protected StreetOperation(IStreetSpecifications streetSpecifications)
		{
			StreetSpecifications = streetSpecifications;
		}

		private int[] StreetHouses { get; set; }

		protected int[] GetStreetHouses()
		{
			if (StreetHouses != null)
				return StreetHouses;

			return StreetHouses = StreetSpecifications.GetStreetHouses();
		}
	}
}
