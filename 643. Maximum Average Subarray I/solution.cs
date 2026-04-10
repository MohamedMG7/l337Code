public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        double windowSum = 0;

        for (int i = 0; i < k; i++) {
            windowSum += nums[i];
        }

        double maxSum = windowSum;

        for (int i = k; i < nums.Length; i++) {
            windowSum += nums[i];
            windowSum -= nums[i - k];
            maxSum = Math.Max(maxSum, windowSum);
        }

        return maxSum / k;
    }
}

// Complexity Analysis
// Time complexity: O(n)
// Space complexity: O(1)