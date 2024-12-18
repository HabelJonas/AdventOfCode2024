namespace Day2.Models;
public class Report(int[] level)
{
	public int[] Level => level;

	public bool IsSafe()
	{
		if (level[0] == level[1])
		{
			return false;
		}
		bool isDescending = level[0] > level[1];
		for (int i = 0; i < level.Length - 1; i++)
		{
			int distance = level[i] - level[i + 1];
			if (isDescending)
			{
				if (distance is < 1 or > 3)
				{
					return false;
				}
			}
			else
			{
				if (distance is > (-1) or < (-3))
				{
					return false;
				}
			}
		}
		return true;
	}
}
