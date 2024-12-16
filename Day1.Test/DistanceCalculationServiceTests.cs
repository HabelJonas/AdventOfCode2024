using Day1.Services;

namespace Day1.Test;

public class DistanceCalculationServiceTests
{
	[Fact]
	public void CalculateSumOfDistances_ReturnsCorrectSum()
	{
		// Arrange
		List<int> left = [3, 4, 2, 1, 3, 3];
		List<int> right = [4, 3, 5, 3, 9, 3];

		// Act
		int result = DistanceCalculationService.CalculateSumOfDistances(left, right);

		// Assert
		Assert.Equal(11, result);
	}
}