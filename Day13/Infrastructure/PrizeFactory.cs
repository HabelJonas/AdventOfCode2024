using Day13.Models;

namespace Day13.Infrastructure;
public static class PrizeFactory
{
	public static Prize CreatePrize(string line)
	{
		string replacedString = line.Replace(" ", string.Empty).Replace("Prize:X=", string.Empty).Replace("Y=", string.Empty);
		string[] coordinates = replacedString.Split(",");
		return new Prize { X = int.Parse(coordinates[0]), Y = int.Parse(coordinates[1]) };
	}
}
