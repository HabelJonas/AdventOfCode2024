using Day2.Models;

namespace Day2.Test;

public class ReportTests
{
	[Fact]
	public void IsSafe_ShouldReturnTrue_ForDescendingLevels()
	{
		// Arrange
		List<int> level = [7, 6, 4, 2, 1];
		Report report = new(level);

		// Act
		bool result = report.IsSafe();

		// Assert
		Assert.True(result);
	}

	[Fact]
	public void Issafe_ShouldReturnFalse_ForAscendingLevelsWithTooBigDistance()
	{
		// Arrange
		List<int> level = [1, 2, 7, 8, 9];
		Report report = new(level);

		// Act
		bool result = report.IsSafe();

		// Assert
		Assert.False(result);
	}

	[Fact]
	public void Issafe_ShouldReturnFalse_ForDescendingLevelsWithTooBigDistance()
	{
		// Arrange
		List<int> level = [9, 7, 6, 2, 1];
		Report report = new(level);

		// Act
		bool result = report.IsSafe();

		// Assert
		Assert.False(result);
	}

	[Fact]
	public void Issafe_ShouldReturnFalse_MixedAscendingAndDescending()
	{
		// Arrange
		List<int> level = [1, 3, 2, 4, 5];
		Report report = new(level);

		// Act
		bool result = report.IsSafe();

		// Assert
		Assert.False(result);
	}

	[Fact]
	public void Issafe_ShouldReturnFalse_NeitherDecreaseNorIncrease()
	{
		// Arrange
		List<int> level = [8, 6, 4, 4, 1];
		Report report = new(level);

		// Act
		bool result = report.IsSafe();

		// Assert
		Assert.False(result);
	}

	[Fact]
	public void Issafe_ShouldReturnTrue_AllAscendingWithCorrectDistance()
	{
		// Arrange
		List<int> level = [1, 3, 6, 7, 9];
		Report report = new(level);

		// Act
		bool result = report.IsSafe();

		// Assert
		Assert.True(result);
	}

	// With Dampener
	[Fact]
	public void IsSafeWithDampener_ShouldReturnTrue_ForDescendingLevels()
	{
		// Arrange
		List<int> level = [7, 6, 4, 2, 1];
		Report report = new(level);

		// Act
		bool result = report.IsSafeWithDampener();

		// Assert
		Assert.True(result);
	}

	[Fact]
	public void IsSafeWithDampener_ShouldReturnFalse_ForAscendingLevelsWithTooBigDistance()
	{
		// Arrange
		List<int> level = [1, 2, 7, 8, 9];
		Report report = new(level);

		// Act
		bool result = report.IsSafeWithDampener();

		// Assert
		Assert.False(result);
	}

	[Fact]
	public void IsSafeWithDampener_ShouldReturnFalse_ForDescendingLevelsWithTooBigDistance()
	{
		// Arrange
		List<int> level = [9, 7, 6, 2, 1];
		Report report = new(level);

		// Act
		bool result = report.IsSafeWithDampener();

		// Assert
		Assert.False(result);
	}

	[Fact]
	public void IsSafeWithDampener_ShouldReturnFalse_MixedAscendingAndDescending()
	{
		// Arrange
		List<int> level = [1, 3, 2, 4, 5];
		Report report = new(level);

		// Act
		bool result = report.IsSafeWithDampener();

		// Assert
		Assert.True(result);
	}

	[Fact]
	public void IsSafeWithDampener_ShouldReturnFalse_NeitherDecreaseNorIncrease()
	{
		// Arrange
		List<int> level = [8, 6, 4, 4, 1];
		Report report = new(level);

		// Act
		bool result = report.IsSafeWithDampener();

		// Assert
		Assert.True(result);
	}

	[Fact]
	public void IsSafeWithDampener_ShouldReturnTrue_AllAscendingWithCorrectDistance()
	{
		// Arrange
		List<int> level = [1, 3, 6, 7, 9];
		Report report = new(level);

		// Act
		bool result = report.IsSafeWithDampener();

		// Assert
		Assert.True(result);
	}

	[Fact]
	public void IsSafeWithDampener_ShouldReturnTrue_ForAscendingLevels()
	{
		// Arrange
		List<int> level = [81, 82, 81, 84, 85];
		Report report = new(level);
		// Act
		bool result = report.IsSafeWithDampener();
		// Assert
		Assert.True(result);
	}

	[Fact]
	public void IsSafeWithDampener_ShouldReturnFalse_ForThreeOfSameValue()
	{
		// Arrange
		List<int> level = [45, 45, 45, 47, 48, 50, 52, 57];
		Report report = new(level);
		// Act
		bool result = report.IsSafeWithDampener();
		// Assert
		Assert.False(result);
	}

	[Theory]
	[InlineData(new[] { 48, 46, 47, 49, 51, 54, 56 }, true)]
	[InlineData(new[] { 1, 1, 2, 3, 4, 5 }, true)]
	[InlineData(new[] { 1, 2, 3, 4, 5, 5 }, true)]
	[InlineData(new[] { 5, 1, 2, 3, 4, 5 }, true)]
	[InlineData(new[] { 1, 4, 3, 2, 1 }, true)]
	[InlineData(new[] { 1, 6, 7, 8, 9 }, true)]
	[InlineData(new[] { 1, 2, 3, 4, 3 }, true)]
	[InlineData(new[] { 9, 8, 7, 6, 7 }, true)]
	[InlineData(new[] { 7, 10, 8, 10, 11 }, true)]
	[InlineData(new[] { 29, 28, 27, 25, 26, 25, 22, 20 }, true)]
	public void TestIsSafeWithDampener(int[] levels, bool expected)
	{
		var report = new Report(new List<int>(levels));
		Assert.Equal(expected, report.IsSafeWithDampener());
	}
}