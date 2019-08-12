// given a set of letters find all the possible words that a user might wanted to type
//  assuming each letter can have other 3 alternatives (random)
class Program
{
	static char[] GetAlternativeLetters(char i)
	{
		return new char[] { i, (char)(i + 1), (char)(i - 1) };
	}

	static IEnumerable<string> PossibleWords(string a)
	{
		IEnumerable<string> words = new List<string>() { "" };
		// go throw each of the typed letters
		foreach (char i in a)
		{
			var letters = GetAlternativeLetters(i);
			var w = new List<string>();
			// for each of the existing words, add each of the possible letters
			foreach (string word in words)
			{
				foreach (char letter in letters)
				{
					w.Add(word + letter);
				}
			}

			words = w;
		}

		return words;
	}

	static void Main(string[] args)
	{
		var ret = PossibleWords("gid");

		ret.ToList().ForEach(Console.WriteLine);
	}
}