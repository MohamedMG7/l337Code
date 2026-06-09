public class Solution {
    public long MaxTotalValue(int[] nums, int k) {
        long max = nums.Max();
        long min = nums.Min();

        return (max - min) * (long)k;
    }
}

// Complexity Analysis
// Time complexity O(n)
// space complexity O(1)