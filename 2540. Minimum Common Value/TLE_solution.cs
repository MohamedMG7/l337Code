public class Solution {
    public int GetCommon(int[] nums1, int[] nums2) {
        int ans = int.MaxValue;
        foreach(int i in nums1){
            foreach(int x in nums2){
                if(i == x){
                    ans = Math.Min(i,ans);
                }
            }
        }
        return ans;
    }
}

// This gets a time limit error
// complexity analysis
// Time Complexity O(n x m)
// space complexity O(1)