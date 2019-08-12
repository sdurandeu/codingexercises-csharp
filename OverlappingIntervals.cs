// the problem with this solution is it can use a lot of memory if times are not 24hs
// see https://codereview.stackexchange.com/questions/126906/finding-the-total-time-elapsed-in-the-union-of-time-intervals
// also see https://leetcode.com/problems/interval-list-intersections/
class Program
{
	struct Signal
	{
		public int startCount { get; set; }
		public int endCount { get; set; }
	}
	static int OverlappingTimes(int[][] timeIntervals)
	{
		var times = new Signal[24];

		// walk-through array and mark starts and ends
		foreach (int[] timeInterval in timeIntervals)
		{
			times[timeInterval[0]].startCount++;
			times[timeInterval[1]].endCount++;
		}

		// walk through times and check overlaps
		int startCount = 0;
		int finalHourCount = 0;
		foreach (Signal signal in times)
		{
			startCount -= signal.endCount;
			startCount += signal.startCount;

			if (startCount > 0)
			{
				finalHourCount++;
			}
		}

		return finalHourCount;
	}

	static void Main(string[] args)
	{
		Console.WriteLine(OverlappingTimes(new[] { new[] { 10, 14 }, new[] { 4, 18 }, new[] { 19, 20 },  new[] { 13, 20 } }));
		//Console.WriteLine(OverlappingTimes(new[] { new[] { 1, 3 }, new[] { 3, 6 }}));
	}
}