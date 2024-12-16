using Day13.Infrastructure;
using Day13.Models;
using Day13.Services;

Console.WriteLine("Hello, World!");
Console.WriteLine("Part One Solution: 39748");
Console.WriteLine("Part Two Solution: 74478585072604");

string filePath = "input.txt";
if (File.Exists(filePath))
{
	string input = File.ReadAllText(filePath);

	string[] machines = input.Split([Environment.NewLine + Environment.NewLine], StringSplitOptions.None);
	long totalCost = 0L;
	foreach (string machine in machines)
	{
		string[] lines = machine.Split(Environment.NewLine);
		Button buttonA = ButtonFactory.CreateButton(lines[0], "ButtonA:X+", 3);
		Button buttonB = ButtonFactory.CreateButton(lines[1], "ButtonB:X+", 1);
		Prize prize = PrizeFactory.CreatePrize(lines[2]);

		long machineCost = MachineCostService.CalculateCost(buttonA, buttonB, prize);
		if (machineCost > 0)
		{
			totalCost += machineCost;
			Console.WriteLine("Cost for this machine:\t" + machineCost);
		}
	}
	Console.WriteLine("Total Cost is:\t" + totalCost);
}
else
{
	Console.WriteLine("File not found.");
}