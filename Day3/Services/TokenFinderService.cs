using System.Text.RegularExpressions;

namespace Day3.Services;
public static class TokenFinderService
{
	public static List<(int, int)> FindFactors(string input)
	{
		List<(int, int)> factors = [];
		string pattern = @"mul\((\d{1,3}),(\d{1,3})\)";
		Regex regex = new(pattern);
		MatchCollection matches = regex.Matches(input);

		foreach (Match match in matches)
		{
			int factor1 = int.Parse(match.Groups[1].Value);
			int factor2 = int.Parse(match.Groups[2].Value);
			factors.Add((factor1, factor2));
		}

		return factors;
	}
}