public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int ans = 0;
        for(int i = 0; i < accounts.Length; i++){
            int temp = 0;
            for(int k = 0; k < accounts[i].Length; k++){
                temp += accounts[i][k];
            }
            ans = Math.Max(ans, temp);
        }
        return ans;
    }
}

// Time Complexity O(n*m)
// Space Complexity O(1)