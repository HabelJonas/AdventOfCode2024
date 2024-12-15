using Day13.Models;

namespace Day13.Services;

public static class MachineCostService
{
	public static int CalculateCost(Button buttonA, Button buttonB, Prize prize)
	{
		int cost = 0;
		try
		{
			var (a, b) = LinearEquationSolver.CalculateLinearSolution(buttonA.X, buttonB.X, prize.X, buttonA.Y, buttonB.Y, prize.Y);
			if (a > 100 || b > 100)
			{
				throw new InvalidOperationException();
			}
			cost += buttonA.Cost * (int)Math.Round(a);
			cost += buttonB.Cost * (int)Math.Round(b);
		}
		catch (InvalidOperationException)
		{
			return -1;
		}

		return cost;
	}
}