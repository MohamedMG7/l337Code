public class Solution {
    public int GetMinDistance(int[] nums, int target, int start) {
        int ans = int.MaxValue;
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] == target){
                int distance = Math.Abs(i - start);
                ans = Math.Min(ans, distance);
            } 
        }
        return ans;
    }
}

// Complexity Analysis
// Time complexity: O(n)
// Space complexity: O(1)