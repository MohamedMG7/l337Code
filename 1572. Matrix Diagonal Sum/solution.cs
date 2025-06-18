public class Solution {
    public int DiagonalSum(int[][] mat) {
        int n = mat.Length;
        int ans = 0;
        for(int i = 0; i < n; i++){
            ans += mat[i][i]; // this returns the primary diagonal
            ans += mat[i][n - i - 1]; // this adds the secondary diagonal
        }
        return mat.Length % 2 == 1 ? ans - mat[n / 2][n / 2] : ans;
    }
}
// Time Complexity O(n)
// Space Complexity O(1)