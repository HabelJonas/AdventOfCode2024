using Day2.Models;

namespace Day2.Test;

public class ReportTests
{
	[Fact]
	public void IsSafe_ShouldReturnTrue_ForDescendingLevels()
	{
		// Arrange
		int[] level = { 7, 6, 4, 2, 1 };
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
		int[] level = { 1, 2, 7, 8, 9 };
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
		int[] level = { 9, 7, 6, 2, 1 };
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
		int[] level = { 1, 3, 2, 4, 5 };
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
		int[] level = { 8, 6, 4, 4, 1 };
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
		int[] level = { 1, 3, 6, 7, 9 };
		Report report = new(level);

		// Act
		bool result = report.IsSafe();

		// Assert
		Assert.True(result);
	}
}