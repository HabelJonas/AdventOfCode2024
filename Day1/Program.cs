using Day1.Services;

Console.WriteLine("Part One:");

string filePath = "input.txt";
if (File.Exists(filePath))
{
	string input;
	List<int> left, right;
	string[] lines;
	ProcessInputFile(filePath, out input, out left, out right, out lines);
	Console.WriteLine(ListComparisonService.CalculateSumOfDistances(left, right));

	Console.WriteLine("Part Two:");

	ProcessInputFile(filePath, out input, out left, out right, out lines);
	Console.WriteLine(ListComparisonService.CalculateSimilarityScore(left, right));
}
else
{
	Console.WriteLine("File not found.");
}

static void ProcessInputFile(string filePath, out string input, out List<int> left, out List<int> right, out string[] lines)
{
	input = File.ReadAllText(filePath);
	input = input.Replace("   ", ",");
	left = [];
	right = [];
	lines = input.Split(Environment.NewLine);
	foreach (string line in lines)
	{
		string[] values = line.Split(",");
		if (values[0] != string.Empty)
		{
			left.Add(int.Parse(values[0]));
			right.Add(int.Parse(values[1]));
		}
	}
}