public class Solution {
    public int GetCommon(int[] nums1, int[] nums2) {
        int i = 0;
        int j = 0;
        
        while(i < nums1.Length && j < nums2.Length){
            if(nums1[i] == nums2[j]) return nums1[i];
            else if(nums1[i] > nums2[j]) j++;
            else if(nums1[i] < nums2[j]) i++;
        }

        return -1;
    }
}

// using two pointers lower the time complexity to
// Time Complexity O(n + m) - if n is 10 and m is 10 then the difference is 5x faster. and it becomes better with bigger count
// Space Complexity O(1) - same