public class Solution
{
    public int LargestPerimeter(int[] nums)
    {
        Array.Sort(nums);
        for (int i = nums.Length - 1; i >= 2; i--)
        {
            if (nums[i] + nums[i - 1] > nums[i - 2])
            {
                long a = nums[i - 2], b = nums[i - 1], c = nums[i];
                if (a + b > c) return (int)(a + b + c);
            }
        }
        return 0;
    }
}

// complexity Analysis:
// Time Complexity: O(n log n) due to sorting
// Space Complexity: O(1)
// sorting in place for primitive types like (int) makes the space complexity O(1)