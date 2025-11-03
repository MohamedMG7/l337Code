public class Solution
{
    public int Rob(int[] nums)
    {
        List<int> best = new List<int>();

        if (nums.Length == 1) return nums[0];
        if (nums.Length == 2) return Math.Max(nums[0], nums[1]);

        best.Add(nums[0]);
        best.Add(Math.Max(nums[1], nums[0]));
        for (int i = 2; i < nums.Length; i++)
        {
            best.Add(Math.Max(nums[i] + best[i - 2], best[i - 1]));
        }

        int ans = 0;
        foreach (int x in best)
        {
            ans = Math.Max(ans, x);
        }

        return ans;
    }
}

// Complexity Analysis
// Time Complexity O(n)
// Space Complexity O(n)
