namespace Day13.Services;

public static class LinearEquationService
{
	public static (double a, double b) CalculateLinearSolution(double a1, double b1, double c1, double a2, double b2, double c2)
	{
		double determinant = (a1 * b2) - (a2 * b1);
		if (determinant == 0)
		{
			throw new InvalidOperationException("The system of equations has no unique solution.");
		}
		double a = ((c1 * (double)b2) - (c2 * (double)b1)) / determinant;
		double b = (((double)a1 * c2) - ((double)a2 * c1)) / determinant;

		if (a != Math.Floor(a) ||
			b != Math.Floor(b) ||
			a < 0 ||
			b < 0)
		{
			throw new InvalidOperationException("The calculated values do not satisfy the original equations or are not integers.");
		}

		return (a, b);
	}
}
