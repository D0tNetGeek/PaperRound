namespace Street.Library.Story1
{
	public interface IStreetTracker
	{
		bool IsValidStreet();
		int NumberOfHouses();
		int NumberOfNorthHouses();
		int NumberOfSouthHouses();
	}
}
