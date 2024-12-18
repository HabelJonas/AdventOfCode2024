// See https://aka.ms/new-console-template for more information
using Day3.Services;

Console.WriteLine("Hello, World!");
Console.WriteLine("Part One:");

string input = File.ReadAllText("input.txt");

List<(int, int)> factors = TokenFinderService.FindFactors(input);

// go over the factors and multiply them and add them to the sum
int sum = 0;
foreach ((int factor1, int factor2) in factors)
{
	sum += factor1 * factor2;
}
Console.WriteLine(sum);
