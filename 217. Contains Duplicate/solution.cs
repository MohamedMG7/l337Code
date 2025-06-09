public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        // 1st solution using sorting
        // Time complexity: O(n log n), Space complexity: O(1) assuming sorting is done in place

        // Array.Sort(nums);
        // for (int i = 0; i < nums.Length - 1; i++)
        // {
        //     if (nums[i] == nums[i + 1])
        //     {
        //         return true;
        //     }
        // }
        // return false;

        // 2nd solution using HashSet
        // Time complexity: O(n), Space complexity: O(n)
        HashSet<int> set = new HashSet<int>();
        foreach (int num in nums)
        {
            if (set.Contains(num))
            {
                return true;
            }
            set.Add(num);
        }
        return false;
    }
}
// first code is sorting the array and then checking for duplicates in O(n log n) time complexity
// space complexity is O(1) because we are not using any extra space -- if we assume that sorting is done in place
// this is a simple solution to the problem

// second solution is using a hashset to store the elements and checking for duplicates in O(n) time complexity, O(n) space complexity

// in-place sorting mean that the sorting algorithm does not return a new array but sorts the original array itself