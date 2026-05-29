public class Solution
{
    public int MinElement(int[] nums)
    {
        int ans = int.MaxValue;

        for (int i = 0; i < nums.Length; i++)
        {
            int n = nums[i];
            int sum = 0;

            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }

            ans = Math.Min(ans, sum);
        }

        return ans;
    }
}

// comlpexity analysis
// this gives the same complexity but less overhead of converting and dealing with immutable strings
// time complexity O(n * m)
// space complexity O(1)