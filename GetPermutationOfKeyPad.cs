// User Presses 2,2 --> you need to output AA AB AC BA BC BB CA CB CC
// Permutations
// Order is O(3^n) or O(4^n) depending on the number of letters per number
// BE careful that word should actually be string builder
class Program
{
	static Dictionary<int, string[]> numbersToLetters = new Dictionary<int, string[]>()
	{
		{  2, new string[] { "A", "B", "C" } },
		{  3, new string[] { "D", "E", "F" } }
	};

	static void GetPermutations(int[] numbers, string word, int currentPosition)
	{
		if (currentPosition == numbers.Length)
		{
			Console.WriteLine(word);
			return;
		}

		foreach (string letter in numbersToLetters[numbers[currentPosition]])
		{
			word += letter;
			GetPermutations(numbers, word, currentPosition + 1);
			word = word.Remove(word.Length - 1);
		}
	}

	static void Main(string[] args)
	{
		GetPermutations(new int[] { 2, 2 }, "", 0);
	}		
}