public class Solution {
    public int ArraySign(int[] nums) {
        if(nums.Contains(0)){
            return 0;
        }
        double res = 1;
        foreach(int n in nums){
            res *= n;
        }

        return res > 1 ? 1 : -1;
    }
    // Time Complexity O(n)
    // Space Complexity O(1)
}