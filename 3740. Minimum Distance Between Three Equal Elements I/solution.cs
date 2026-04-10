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
                int currentDistance = CalculateDistance(indecies[nums[i]]);
                ans = Math.Min(ans, currentDistance);
            }
        }

        return ans == int.MaxValue ? -1 : ans;
    }

    int CalculateDistance(List<int> indices)
    {
        int min = int.MaxValue;

        for (int x = 0; x <= indices.Count - 3; x++)
        {
            int i = indices[x];
            int j = indices[x + 1];
            int k = indices[x + 2];

            int dist = Math.Abs(i - j) + Math.Abs(j - k) + Math.Abs(k - i);

            min = Math.Min(min, dist);
        }

        return min;
    }
}

// complexity analysis
// time complexity: O(n)
// space complexity: O(n)