// longest increasing subsequence
// Input : [0, 8, 4, 12, 2, 10, 6, 14, 1, 9, 5, 13, 3, 11, 7, 15]
// Output : 6
// https://www.interviewbit.com/problems/longest-increasing-subsequence/
// Even if this algorithm does one loop over the array it requires keeping the sorted set so the complecity is O(nlogn)
using System;
using System.Collections.Generic;
using System.Linq;

class Solution {
    public int lis(List<int> A) {
        if (A.Count() == 0) {
            return 0;
        }
        
        int max = 1;
        SortedDictionary<int, int> longestSequence = new SortedDictionary<int, int>();
        for(int i = 0; i < A.Count(); i++)
        {
            var latest = longestSequence.Where(k => k.Key < A[i]);
            if (latest.Count() == 0)
            {
                if (!longestSequence.ContainsKey(A[i]))
                {
                    longestSequence[A[i]] = 1;
                }
            }
            else 
            {
                var latestValue = latest.Last().Value + 1;              
                longestSequence[A[i]] = latestValue;                               
                max = Math.Max(latestValue, max);
            }
        }
        
        return max;
    }
}



