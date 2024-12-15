using Day13.Infrastructure;
using Day13.Models;
using Day13.Services;

Console.WriteLine("Hello, World!");

string filePath = "input.txt";
if (File.Exists(filePath))
{
	string input = File.ReadAllText(filePath);

	string[] machines = input.Split([Environment.NewLine + Environment.NewLine], StringSplitOptions.None);
	int totalCost = 0;
	foreach (string machine in machines)
	{
		string[] lines = machine.Split(Environment.NewLine);
		Button buttonA = ButtonFactory.CreateButton(lines[0], "ButtonA:X+", 3);
		Button buttonB = ButtonFactory.CreateButton(lines[1], "ButtonB:X+", 1);
		Prize prize = PrizeFactory.CreatePrize(lines[2]);

		int machineCost = MachineCostService.CalculateCost(buttonA, buttonB, prize);
		if (machineCost > 0)
		{
			totalCost += machineCost;
			Console.WriteLine("Cost for this machine: " + machineCost);
		}
	}
	Console.WriteLine("Total Cost is: " + totalCost);
}
else
{
	Console.WriteLine("File not found.");
}