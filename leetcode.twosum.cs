public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        // first pass, build the dictionary
       var dictionary = new Dictionary<int, int>(nums.Length);
        
        for (var i = 0; i < nums.Length; i++)
        {
            if (!dictionary.ContainsKey(nums[i])) {
                dictionary.Add(nums[i], i);  
            }
            
            int complement = target - nums[i];
            
            if (dictionary.ContainsKey(complement) && i != dictionary[complement]) {
                return new int[] { dictionary[complement], i };
            }
        }
        
        return default(int[]);
    }
}
