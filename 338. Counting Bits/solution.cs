public class Solution {
    public int[] CountBits(int n) {
        int[] ans = new int[n+1];
        for(int i = 0; i <= n; i++){
            string BR = Convert.ToString(i, 2);
            ans[i] = (BR.Count(c => c == '1'));
        }
        return ans;
    }
}

// complexity analysis
// Time Complexity O(n log n)
// Space Complexity O(n)