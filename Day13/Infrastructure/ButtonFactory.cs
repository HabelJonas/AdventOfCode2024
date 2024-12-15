using Day13.Models;

namespace Day13.Infrastructure;
public static class ButtonFactory
{
	public static Button CreateButton(string line, string prefix, int cost)
	{
		string replacedString = line.Replace(" ", string.Empty).Replace(prefix, string.Empty).Replace("Y+", string.Empty);
		string[] coordinates = replacedString.Split(",");
		return new Button { X = int.Parse(coordinates[0]), Y = int.Parse(coordinates[1]), Cost = cost };
	}
}
