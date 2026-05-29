public class Solution {
    public int MinElement(int[] nums) {
        int ans = int.MaxValue;

        for(int i = 0 ; i < nums.Length; i++){
            int sum = 0;
            foreach(char c in nums[i].ToString()){
                sum += c - '0';
            }
            ans = int.Min(sum,ans);
        }

        return ans;
    }
}

// complexity analysis
// time complexity O(m * n) where m is the count of numbers in nums[] and n is the length of the number
// space complexity O(1)