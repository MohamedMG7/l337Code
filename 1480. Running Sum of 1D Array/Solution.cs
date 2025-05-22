public class Solution {
    public int[] RunningSum(int[] nums) {
        int current = 0;
        for(int i = 0; i < nums.Length; i++){
            current += nums[i];
            nums[i] = current;
        }
        return nums;
    }
}

// complexity
// O(n) Time Complexity
// O(1) Space Complexity