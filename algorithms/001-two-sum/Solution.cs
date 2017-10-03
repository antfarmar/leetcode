class Solution {
    
    // One-pass using Dictionary
    public int[] TwoSum(int[] nums, int target) {
        
        var map = new Dictionary<int, int>();
        
        for (int i = 0; i < nums.Length; i++) {
            
            int complement = target - nums[i];
            
            if (map.ContainsKey(complement)) {
                return new int[] { map[complement], i };
            }
            
            map[nums[i]] = i;
        }
        
        // If no return yet, there is no solution.
        throw new System.ArgumentException("No solution");
    }
}