//straight forward solution using list to store the elements
public class Solution
{
    public int SingleNumber(int[] nums)
    {
        if (nums.Length == 1)
        {
            return nums[0];
        }
        List<int> n = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (n.Contains(nums[i]))
            {
                n.Remove(nums[i]);
            }
            else
            {
                n.Add(nums[i]);
            }
        }
        return n[0];
    }
}

// Complexity Analysis:
// Time Complexity: O(n) where n is the number of elements in the array
// Space Complexity: O(n) in the worst case, if all elements are unique and stored in the list

// there is better solution using bit manupulation by XOR opertor
// the idea of XOR operator is that a^a=0 and a^0=a
// so if we XOR all the elements in the array, the elements that appear twice will cancel
// here is the solution 

// public class Solution {
//     public int SingleNumber(int[] nums) {
//         int result = 0;
//         foreach(int n in nums){
//             result ^= n;
//         }
//         return result;
//     }
// }