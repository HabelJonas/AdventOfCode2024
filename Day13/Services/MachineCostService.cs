using Day13.Models;

namespace Day13.Services;

public static class MachineCostService
{
	public static long CalculateCost(Button buttonA, Button buttonB, Prize prize)
	{
		long cost = 0;
		try
		{
			var (a, b) = LinearEquationService.CalculateLinearSolution(buttonA.X, buttonB.X, prize.X, buttonA.Y, buttonB.Y, prize.Y);
			// Part One restriction
			//if (a > 100 || b > 100)
			//{
			//	throw new InvalidOperationException();
			//}
			cost += buttonA.Cost * (long)a;
			cost += buttonB.Cost * (long)b;
		}
		catch (InvalidOperationException)
		{
			return -1;
		}

		return cost;
	}
}