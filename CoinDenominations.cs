// https://www.interviewcake.com/question/csharp/coin
// The algorithm below is just a test for recursion, it does not solve the problem
class Program
{
	static void CoinCombination(int[] coins, List<int> selectedCoins)
	{
		int sum = selectedCoins.Sum();

		if (sum > 4)
		{
			return;
		}
		else if (sum == 4)
		{
			selectedCoins.ToList().ForEach(Console.Write);
			Console.WriteLine();
		}
		else
		{
			foreach (int c in coins)
			{
				selectedCoins.Add(c);
				CoinCombination(coins, selectedCoins);
				selectedCoins.Remove(c);
			}
		}
	}

	static void Main(string[] args)
	{
		CoinCombination(new int[] { 1, 2, 3, 4 }, new List<int>());
	}
}