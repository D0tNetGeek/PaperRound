using System.IO;
using System.Linq;

namespace Street.Library.Common
{
	public class FileStreetSpecifications:IStreetSpecifications
	{
		private int[] _streetSpecifications;
	    private string FileName { get; set; }
		public FileStreetSpecifications(string fileName)
		{
			FileName = fileName;
		}

		public int[] GetStreetHouses()
		{
			if (_streetSpecifications != null)
				return _streetSpecifications;

			return _streetSpecifications = File.ReadAllText(FileName).Split(' ').Select(int.Parse).ToArray();
		}
	}

}