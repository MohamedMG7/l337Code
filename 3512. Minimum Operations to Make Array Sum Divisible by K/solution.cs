public class Solution {
    public int MinOperations(int[] nums, int k) {
        return nums.Sum() % k;   
    }
}

// Complexity Analysis
// Time Complexity O(n) looping on array items to get the sum
// Space complexity O(1) 