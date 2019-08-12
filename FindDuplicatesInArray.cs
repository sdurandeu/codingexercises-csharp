// https://www.interviewcake.com/question/csharp/find-duplicate-optimize-for-space
// This assumes there is at least one duplicate (n values in n+1 array lenght)
class Program
{
	public static int FindDuplicates(int[] values)
	{
		int min = 1;
		int max = values.Length - 1;

		while (max > min)
		{
			int midPoint = (min + max) / 2;
			var ocurrences = values.Count(i => i >= min && i <= midPoint);

			if (ocurrences > midPoint - min + 1)
			{
				// keep the lower half
				max = midPoint;
			}
			else
			{
				// keep the upper half
				min = midPoint + 1;
			}
		}

		return max;
	}

	static void Main(string[] args)
	{
		Console.WriteLine(FindDuplicates(new int[] { 1, 2, 2, 4, 3 }));
	}
}