public class Solution {
    public bool IsMonotonic(int[] nums) {
        if(nums.Length <= 2){
            return true;
        }

        int i = 1;
        // Skip initial equal elements
        while (i < nums.Length && nums[i] == nums[i - 1]) {
            i++;
        }

        // check if all elements are equal then return true
        if (i == nums.Length) {
            return true;
        }

        bool isIncreasing = nums[i] > nums[i - 1];
        
        for(; i < nums.Length; i++){

            if(isIncreasing && nums[i] < nums[i - 1]){
                return false;
            }

            if(!isIncreasing && nums[i] > nums[i - 1]){
                return false;
            }
        }

        return true;
        
    }
}

// Time Complexity O(n)
// Space Complexity O(1)