using Day2.Models;

Console.WriteLine("Part One:");

string filePath = "input.txt";
if (File.Exists(filePath))
{
	string input = File.ReadAllText(filePath);
	string[] lines = input.Split(Environment.NewLine);

	List<Report> reports = new();
	foreach (string line in lines)
	{
		int[] level = line.Split(" ").Select(int.Parse).ToArray();
		Report report = new(level);
		reports.Add(report);
	}

	int numberOfSafeReports = reports.Count(report => report.IsSafe());
	Console.WriteLine("Number of safe reports: " + numberOfSafeReports);

	Console.WriteLine("Part Two:");

	//ProcessInputFile(filePath, out input, out left, out right, out lines);
	//Console.WriteLine(ListComparisonService.CalculateSimilarityScore(left, right));
}
else
{
	Console.WriteLine("File not found.");
}

