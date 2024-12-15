using Day13.Models;
using Day13.Services;

namespace Day13.Test;

public class MachineCostServiceTests
{
    /// <summary>
    /// LES = Linear System of Equations / Linear Equation System
    /// </summary>
    [Fact]
    public void LES_Solvable_Return_Cost()
    {
        // Arrange
        Button buttonA = new() { X = 94, Y = 34, Cost = 3};
        Button buttonB = new() { X = 22, Y = 67 , Cost = 1};
        Prize prize = new() { X = 8400, Y = 5400 };
        MachineCostService mcc = new(buttonA, buttonB, prize);

        // Act
        int result = mcc.CalculateCost();

        // Assert
        Assert.Equal(280, result);
    }

    [Fact]
    public void LES_Solvable_But_Too_Many_Button_Presses_Neccessary_Return_MinusOne()
    {
        // Arrange
        Button buttonA = new() { X = 26, Y = 66, Cost = 3 };
        Button buttonB = new() { X = 67, Y = 21, Cost = 1 };
        Prize prize = new() { X = 12748, Y = 12176 };
        MachineCostService mcc = new(buttonA, buttonB, prize);

        // Act
        int result = mcc.CalculateCost();

        // Assert
        Assert.Equal(-1, result);
    }

    [Fact]
    public void LES_Solvable_But_Too_Many_Button_Presses_Neccessary2_Return_MinusOne()
    {
        // Arrange
        Button buttonA = new() { X = 69, Y = 23, Cost = 3 };
        Button buttonB = new() { X = 27, Y = 71, Cost = 1 };
        Prize prize = new() { X = 18641, Y = 10279 };
        MachineCostService mcc = new(buttonA, buttonB, prize);

        // Act
        int result = mcc.CalculateCost();

        // Assert
        Assert.Equal(-1, result);
    }

    [Fact]
    public void LES_Solvable2_Return_Cost()
    {
        // Arrange
        Button buttonA = new() { X = 17, Y = 86, Cost = 3 };
        Button buttonB = new() { X = 84, Y = 37, Cost = 1 };
        Prize prize = new() { X = 7870, Y = 6450 };
        MachineCostService mcc = new(buttonA, buttonB, prize);

        // Act
        int result = mcc.CalculateCost();

        // Assert
        Assert.Equal(200, result);
    }
}