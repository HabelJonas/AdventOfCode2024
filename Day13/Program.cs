using Day13.Models;
using Day13.Services;

Console.WriteLine("Hello, World!");

string filePath = "input.txt";
if (File.Exists(filePath))
{
    string input = File.ReadAllText(filePath);

    string[] machines = input.Split(new[] { Environment.NewLine + Environment.NewLine }, StringSplitOptions.None);
    int totalCost = 0;
    foreach (string machine in machines)
    {
        Button? buttonA = null;
        Button? buttonB = null;
        Prize? prize = null;
        string[] lines = machine.Split(Environment.NewLine);
        for (int i = 0; i < 3; i++)
        {
            if (i == 0)
            {
                string replacedString = lines[i].Replace(" ", string.Empty); // => "ButtonA:X+94,Y+34"
                replacedString = replacedString.Replace("ButtonA:X+", string.Empty); // => "94,Y+34"
                replacedString = replacedString.Replace("Y+", string.Empty); // => "94,34"
                string[] buttonCoordinates = replacedString.Split(",");
                buttonA = new() { X = int.Parse(buttonCoordinates[0]), Y = int.Parse(buttonCoordinates[1]), Cost = 3 };
            }
            else if (i == 1)
            {
                string replacedString = lines[i].Replace(" ", string.Empty); // => "ButtonB:X+94,Y+34"
                replacedString = replacedString.Replace("ButtonB:X+", string.Empty); // => "94,Y+34"
                replacedString = replacedString.Replace("Y+", string.Empty); // => "94,34"
                string[] buttonCoordinates = replacedString.Split(",");
                buttonB = new() { X = int.Parse(buttonCoordinates[0]), Y = int.Parse(buttonCoordinates[1]), Cost = 1 };
            }
            else if (i == 2)
            {
                string replacedString = lines[i].Replace(" ", string.Empty); // => "Prize:X=8400,Y=5400"
                replacedString = replacedString.Replace("Prize:X=", string.Empty); // => "8400,Y=5400"
                replacedString = replacedString.Replace("Y=", string.Empty); // => "8400,5400"
                string[] prizeCoordinates = replacedString.Split(",");
                prize = new() { X = int.Parse(prizeCoordinates[0]), Y = int.Parse(prizeCoordinates[1]) };
            }
        }
        MachineCostService mcc = new(buttonA!, buttonB!, prize!);
        int machineCost = mcc.CalculateCost();
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
