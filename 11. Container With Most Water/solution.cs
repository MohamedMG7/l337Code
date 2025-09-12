public class Solution
{
    public int MaxArea(int[] height)
    {
        int p1 = 0;
        int p2 = height.Length - 1;
        int ans = 0;

        while (p1 < p2)
        {
            int fh = height[p1];
            int sh = height[p2];
            int w = p2 - p1;
            int s = w * Math.Min(fh, sh);
            ans = Math.Max(ans, s);
            if (fh < sh)
            {
                p1++;
            }
            else { p2--; }
        }

        return ans;
    }
}

// complexity Analysis:
// Time Complexity: O(n)
// Space Complexity: O(1)