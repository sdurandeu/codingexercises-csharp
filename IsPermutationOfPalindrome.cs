// https://www.interviewcake.com/question/csharp/permutation-palindrome
class Program
{
	static bool IsPermutationOfPalindrome(string s)
	{
		var lettersHash = new Dictionary<char, int>();

		foreach (char c in s)
		{
			if (lettersHash.ContainsKey(c))
			{
				lettersHash[c]++;
			}
			else
			{
				lettersHash.Add(c, 1);
			}
		}

		// check that the letters come in pairs have mod 2 = 0
		int lettersNotInPairs = lettersHash.Values.Count(c => c % 2 > 0);

		if (lettersNotInPairs > 1)
		{
			return false;
		}

		return true;
	}

	static void Main(string[] args)
	{
		Console.WriteLine(IsPermutationOfPalindrome("ciivvviic"));
	}
}
