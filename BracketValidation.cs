// https://www.interviewcake.com/question/csharp/bracket-validator
// https://www.hackerrank.com/challenges/balanced-brackets/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=stacks-queues
class Program
{
	static bool CheckBrackets(string value)
	{
		var stack = new Stack<char>();
		var openersToClosers = new Dictionary<char, char>
		{
			{ '{', '}' },
			{ '[', ']' },
			{ '(', ')' },
		};

		var openers = new HashSet<char>(openersToClosers.Keys);
		var closers = new HashSet<char>(openersToClosers.Values);

		for (int i = 0; i < value.Length; i++)
		{
			// it ignores other characters not on the closers or openers list
			if (openers.Contains(value[i]))
			{
				stack.Push(value[i]);
			}
			else if (closers.Contains(value[i]))
			{
				if (stack.Count == 0) { return false; }
				var stackValue = stack.Pop();
				if (openersToClosers[stackValue] != value[i]) { return false; };
			}
		}

		return stack.Count > 0 ? false : true;
	}

	static void Main(string[] args)
	{
		Console.WriteLine(CheckBrackets("{ [ ] ( ) }"));
	}
}