namespace Day13.Services;

public static class LinearEquationSolver
{
    /// <summary>
    /// Solves a system of linear equations with two unknowns.
    /// a1 * a + b1 * b = c1
    /// a2 * a + b2 * b = c2
    /// </summary>
    /// <param name="a1">The coefficient of x in the first equation.</param>
    /// <param name="b1">The coefficient of y in the first equation.</param>
    /// <param name="c1">The constant term in the first equation.</param>
    /// <param name="a2">The coefficient of x in the second equation.</param>
    /// <param name="b2">The coefficient of y in the second equation.</param>
    /// <param name="c2">The constant term in the second equation.</param>
    /// <returns>A tuple containing the values of a and b that solve the system of equations.</returns>
    /// <exception cref="InvalidOperationException">Thrown when the system of equations has no unique solution.</exceptio
    public static (double a, double b) CalculateLinearSolution(double a1, double b1, double c1, double a2, double b2, double c2)
    {
        double determinant = a1 * b2 - a2 * b1;
        if (determinant == 0)
        {
            throw new InvalidOperationException("The system of equations has no unique solution.");
        }
        double a = (c1 * b2 - c2 * b1) / determinant;
        double b = (a1 * c2 - a2 * c1) / determinant;

        if (a1 * a + b1 * b != c1 ||
            a2 * a + b2 * b != c2 ||
            a != Math.Floor(a) ||
            b != Math.Floor(b) )
        {
            throw new InvalidOperationException("The calculated values do not satisfy the original equations or are not integers.");
        }

        return (a, b);
    }
}
