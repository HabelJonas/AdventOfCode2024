using Day3.Services;

namespace Day3.Test;

public class UnitTest1
{
	[Fact]
	public void Test1()
	{
		// Arrange
		List<(int, int)> expected = [(2, 4), (5, 5), (11, 8), (8, 5)];
		string input = "xmul(2,4)%&mul[3,7]!@^do_not_mul(5,5)+mul(32,64]then(mul(11,8)mul(8,5))";

		// Act
		List<(int, int)> factors = TokenFinderService.FindFactors(input);

		// Assert
		Assert.Equal(expected, factors);
	}
}