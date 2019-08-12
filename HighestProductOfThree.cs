// https://www.interviewcake.com/question/csharp/highest-product-of-3?course=fc1&section=greedy
// https://leetcode.com/problems/maximum-product-of-three-numbers/submissions/
public class Solution {
    public int MaximumProduct(int[] nums) {
                
        int highestProductOfTwo = nums[0] * nums[1];
        int lowestProductOfTwo = nums[0] * nums[1];
        int highestProductOfThree = nums[0] * nums[1] * nums[2];
        int lowest = Math.Min(nums[0], nums[1]);
        int highest = Math.Max(nums[0], nums[1]);
        
        for (int i = 2; i < nums.Length; i++)
        {
            highestProductOfThree = Math.Max(Math.Max(highestProductOfThree, highestProductOfTwo * nums[i]), lowestProductOfTwo * nums[i]);
            
            lowestProductOfTwo = Math.Min(Math.Min(lowestProductOfTwo, lowest * nums[i]), highest * nums[i]);
            highestProductOfTwo = Math.Max(Math.Max(highestProductOfTwo, highest * nums[i]), lowest * nums[i]);
                        
            lowest = Math.Min(lowest, nums[i]);
            highest = Math.Max(highest, nums[i]);
        }
        
        return highestProductOfThree;
    }
}