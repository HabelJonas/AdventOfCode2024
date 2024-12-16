namespace Day1.Services;
public static class DistanceCalculationService
{
	public static int CalculateSumOfDistances(List<int> left, List<int> right)
	{
		int sum = 0;
		int iterations = left.Count;
		for (int i = 0; i < iterations; i++)
		{
			int minLeft = left.Min();
			int minRight = right.Min();
			int distance = minLeft - minRight;
			sum += Math.Abs(distance);
			left.Remove(minLeft);
			right.Remove(minRight);
		}
		return sum;
	}
}
