public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        // first pass, build the dictionary
       IDictionary<int, int> dictionary = new Dictionary<int, int>();
        
        for (int i = 0; i < nums.Length; i++)
        {
            dictionary.Add(nums[i], i);
        }
        
        // second pass, check if the complement exists
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (dictionary.ContainsKey(complement) && i != dictionary[complement]) {
                return new[] { i, dictionary[complement] };
            }
        }
        
        return null;
    }
}
