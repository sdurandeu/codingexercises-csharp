// https://app.codility.com/programmers/lessons/16-greedy_algorithms/max_nonoverlapping_segments/start/
using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");
// Not 100% correct
class Solution {
    public int solution(int[] A, int[] B) {
        int result = A.Length;
        int i = 0;
        
        while (i < A.Length - 1)
        {
            int nextPosition = 0;
            for (int innerIndex = i+1; innerIndex < A.Length; innerIndex++)
            {
                // if next segments starts after the beginning of this one 
                if (A[innerIndex] <= B[i])
                {
                    result--;
                    nextPosition = innerIndex;
                }
            }
            
            i = nextPosition != 0 ? nextPosition + 1 : i + 1;
        }
        
        return result;
    }
}