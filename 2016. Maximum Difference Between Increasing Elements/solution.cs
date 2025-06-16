public class Solution {
    public int MaximumDifference(int[] nums) {
        int minSoFar = nums[0];
        int maxDiff = -1;

        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] > minSoFar) {
                maxDiff = Math.Max(maxDiff, nums[i] - minSoFar);
            } else {
                minSoFar = nums[i];
            }
        }

        return maxDiff;
    }
}

// Time Complexity O(n)
// Space Complexity O(1)