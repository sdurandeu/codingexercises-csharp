// https://codility.com/media/train/13-CaterpillarMethod.pdf
// https://leetcode.com/problems/subarray-sum-equals-k/
//Problem: Given a sequence of nonnegative integers A and an integer T, return whether there is a *continuous sequence* of A that sums up to exactly T
//Example:
//[23, 5, 4, 7, 2, 11], 20. Return True because 7 + 2 + 11 = 20
//[1, 3, 5, 23, 2], 8. Return True because 3 + 5 = 8
//[1, 3, 5, 23, 2], 7 Return False because no sequence in this array adds… 

class Program
{
	static bool FindSubarraySum(int[] nums, int k)
	{
		int front = 0;
		int totalSum = 0;

		for (int back = 0; back < nums.Length; back++)
		{
			while (front < nums.Length && totalSum < k) {
				totalSum += nums[front];
				front++;
			}

			if (totalSum == k) { return true; }

			totalSum -= nums[back];
		}

		return false;
	}

	static void Main(string[] args)
	{
		Console.WriteLine(FindSubarraySum(new int[] { 1, 3, 5, 23, 2 }, 35));
	}
}


