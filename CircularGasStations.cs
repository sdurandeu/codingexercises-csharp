// https://www.interviewbit.com/problems/gas-station/
// The idea is that you need to check:
//	1. There is enough gas to complete the circuit TotalSum(gas) > TotalSum(cost)
//	1. You accumulate the cost spent so far and if you hit a negative you restart
class Solution {
    public int canCompleteCircuit(List<int> A, List<int> B) {
        int n = A.Count();
        
        int gasSum = A.Sum();
        int costSum = B.Sum();
        
        if (costSum > gasSum) { 
            return -1;
        }
        
        int cumulative = 0;
        int minPosition = 0;
        for (int i = 0; i < n; i++) {
            cumulative += A[i] - B[i];
            
           if (cumulative < 0) {
               minPosition = i + 1;
               cumulative = 0;
           }
        }
        
        return minPosition;
    }
}