public class Solution {
    public int MinimumDistance(int[] nums) {

        if (nums.Length < 3) return -1;

        Dictionary<int, List<int>> indecies = new Dictionary<int, List<int>>();
        int ans = int.MaxValue;

        for (int i = 0; i < nums.Length; i++)
        {
            if (!indecies.ContainsKey(nums[i]))
            {
                indecies[nums[i]] = new List<int>();
            }

            indecies[nums[i]].Add(i);

            if (indecies[nums[i]].Count >= 3)
            {
                var list = indecies[nums[i]];
                int n = list.Count;

                int dist = 2 * (list[n - 1] - list[n - 3]);

                ans = Math.Min(ans, dist);
            }
        }

        return ans == int.MaxValue ? -1 : ans;
    }
}

// complexity analysis
// time complexity: O(n)
// space complexity: O(n)
