// https://www.careercup.com/page?pid=facebook-interview-questions&job=solutions-engineer-interview-questions
class Program
{
	public static int NonZeroToLeft(int[] A)
	{
		int nonCeroCount = 0;
		int ceroLookup = 0;
		int numberLookup = A.Length - 1;

		while (ceroLookup < numberLookup)
		{
			//look for next cero
			while (ceroLookup < A.Length && A[ceroLookup] != 0)
			{
				ceroLookup++;
				nonCeroCount++;
			}

			//look for next number
			while (numberLookup > -1 && A[numberLookup] == 0)
			{
				numberLookup--;
			}

			// swap
			if (ceroLookup < numberLookup)
			{
				int temp = A[ceroLookup];
				A[ceroLookup] = A[numberLookup];
				A[numberLookup] = temp;
			}
		}

		A.ToList().ForEach(Console.WriteLine);

		return nonCeroCount;
	}

	static void Main(string[] args)
	{
		//int nonCeroCount = NonZeroToLeft(new[] { 1, 0, 2, 0, 0, 3, 4 });
		int nonCeroCount = NonZeroToLeft(new int[] { });
		Console.WriteLine($"Non cero count: {nonCeroCount}");
	}
}