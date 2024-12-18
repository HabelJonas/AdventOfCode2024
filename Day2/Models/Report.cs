namespace Day2.Models;
public class Report(List<int> levels)
{
	public bool IsSafe()
	{
		if (levels.Count < 2)
		{
			return true;
		}

		if (levels[0] == levels[1])
		{
			return false;
		}
		bool isDescending = levels[0] > levels[1];
		for (int i = 0; i < levels.Count - 1; i++)
		{
			int distance = levels[i] - levels[i + 1];
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

	public bool IsSafeWithDampener()
	{
		if (IsSafe())
		{
			return true;
		}
		List<int> original = new(levels);
		for (int i = 0; i < original.Count; i++)
		{
			List<int> modifiedLevels = new(original);
			modifiedLevels.RemoveAt(i);
			levels = modifiedLevels;
			if (IsSafe())
			{
				return true;
			}
		}

		return false;
	}
}
