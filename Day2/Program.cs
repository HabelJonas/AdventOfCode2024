using Day2.Models;

Console.WriteLine("Part One:");

string filePath = "input.txt";
if (File.Exists(filePath))
{
	string input = File.ReadAllText(filePath);
	string[] lines = input.Split(Environment.NewLine);

	List<Report> reports = [];
	foreach (string line in lines)
	{
		List<int> level = line.Split(" ").Select(int.Parse).ToList();
		Report report = new(level);
		reports.Add(report);
	}

	int numberOfSafeReports = reports.Count(report => report.IsSafe());
	Console.WriteLine("Number of safe reports: " + numberOfSafeReports);

	Console.WriteLine("Part Two:");

	int numberOfSafeReportsWithDampener = reports.Count(report => report.IsSafeWithDampener());
	Console.WriteLine("Number of safe reports with dampener: " + numberOfSafeReportsWithDampener);
}
else
{
	Console.WriteLine("File not found.");
}

