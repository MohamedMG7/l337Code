public class Solution {
    public void MoveZeroes(int[] nums) {
        int lastNonZeroIndex = 0;

        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] != 0) {
                nums[lastNonZeroIndex++] = nums[i];
            }
        }

     
        for (int i = lastNonZeroIndex; i < nums.Length; i++) {
            nums[i] = 0;
        }
    }
}

// time complexity O(n)
// space complexity O(1)