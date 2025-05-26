public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int left = 0;
        int right = nums.Length - 1;

        // just a shortcut for a known case
        if(nums[0] >= target){
            return 0;
        }

        while(left <= right){
            int mid = left + (right - left) / 2; // avoid integer overflow
            
            if(nums[mid] == target){
                return mid;
            }

            if(nums[mid] < target){
                left = mid + 1;
            }else{
                right = mid - 1;
            }
        }

        return left;
    }
}