// Say you have an array for which the ith element is the price of a given stock on day i.
// If you were only permitted to complete at most one transaction (ie, buy one and sell one share of the stock), design an algorithm to find the maximum profit.
// This resembles to the Kadane's algorithm (maximum subarray sum)
class Solution {
    public int maxProfit(List<int> A) {
        if (A.Count() < 2) { return 0; }
        
        int min = A[0];
        int max = A[0];
        int profit = 0;
        for(int i = 1; i < A.Count(); i++)
        {
            if (A[i] < min)
            {
                min = A[i];
                max = 0;
            }
            
            max = Math.Max(max, A[i]);
            profit = Math.Max(profit, max - min);
        }
        
        return profit;
    }
}