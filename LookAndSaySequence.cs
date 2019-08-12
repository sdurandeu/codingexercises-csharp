public static string ReadOutLoud(string previousNumber)
{
	StringBuilder newNumber = new StringBuilder();
	char previousCharacter = previousNumber[0];
	int count = 1;
	for (int i = 1; i < previousNumber.Length; i++)
	{
		if (previousNumber[i] != previousCharacter)
		{
			newNumber.Append(count).Append(previousCharacter);
			count = 1;
		}
		else
		{
			count++;
		}

		previousCharacter = previousNumber[i];
	}

	newNumber.Append(count).Append(previousCharacter);

	return newNumber.ToString();
}
public static void LookAndSay(int n)
{
	string i = "1";
	Console.WriteLine(i);
	foreach(int iterations in Enumerable.Range(1, n))
	{
		i = ReadOutLoud(i);
		Console.WriteLine(i);
	}
}

static void Main(string[] args)
{
	LookAndSay(10);
}