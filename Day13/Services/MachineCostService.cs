using Day13.Models;

namespace Day13.Services;

public class MachineCostService(Button buttonA, Button buttonB, Prize prize)
{
    public int X { get; set; }
    public int Y { get; set; }
    public Button ButtonA { get; } = buttonA;
    public Button ButtonB { get; } = buttonB;
    public Prize Prize { get; } = prize;

    public int CalculateCost()
    {
        int cost = 0;
        try
        {
            var (a, b) = LinearEquationSolver.CalculateLinearSolution(ButtonA.X, ButtonB.X, Prize.X, ButtonA.Y, ButtonB.Y, Prize.Y);
            if (a > 100 || b > 100)
            {
                throw new InvalidOperationException();
            }
            cost += ButtonA.Cost * (int)Math.Round(a);
            cost += ButtonB.Cost * (int)Math.Round(b);
        }
        catch (InvalidOperationException)
        {
            return -1;
        }

        return cost;
    }
}