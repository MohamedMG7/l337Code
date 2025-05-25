public class Solution {
    public int Search(int[] nums, int target) {
        int left = 0; // first index
        int right = nums.Length - 1; // the last index

        while(left <= right){ // keep looping as long as left index is not bigger than right one if it is bigger then we can not find the number
            int mid = left + (right - left) / 2; // this is safer than (right + left) / 2 to avoid integer overflow on big array
            if(nums[mid] == target){
                return mid;
            }

            if(nums[mid] < target){
                left = mid + 1;
            }else{
                right = mid - 1;
            }
        }

        return -1;
    }
}