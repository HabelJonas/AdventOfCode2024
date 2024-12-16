using Day1.Services;

Console.WriteLine("Part One:");

string filePath = "input.txt";
if (File.Exists(filePath))
{
	string input = File.ReadAllText(filePath);
	input = input.Replace("   ", ",");
	List<int> left = [];
	List<int> right = [];
	string[] lines = input.Split(Environment.NewLine);
	foreach (string line in lines)
	{
		string[] values = line.Split(",");
		if (values[0] != string.Empty)
		{
			left.Add(int.Parse(values[0]));
			right.Add(int.Parse(values[1]));
		}
	}
	Console.WriteLine(DistanceCalculationService.CalculateSumOfDistances(left, right));
}
else
{
	Console.WriteLine("File not found.");
}
