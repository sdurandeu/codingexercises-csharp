// Given a list of integers and a target number, list all pairs that sum up to that number  
// Each number can be used only once
class Program
{
	static void ListPairs(int[] A, int target)
	{
		// create a dictionary with each number and how many ocurrences
		var hash = new Dictionary<int, int>();

		for (int i = 0; i < A.Length; i++)
		{
			if (!hash.ContainsKey(A[i]))
			{
				hash[A[i]] = 1;
			}
			else
			{
				hash[A[i]]++;
			}
		}

		foreach (int i in A)
		{
			// check if the complement exists and has remaining ocurrences
			int complement = target - i;
			if (hash.ContainsKey(complement) && hash[complement] > 0 && hash[i] > 0)
			{
				Console.WriteLine($"{i} {complement}");
				hash[i]--;
				hash[complement]--;
			}
		}
	}

	static void Main(string[] args)
	{
		ListPairs(new[] { -1, -1, -1, -1, 7, 8 }, -2);
	}
}