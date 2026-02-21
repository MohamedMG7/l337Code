public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        int ans = 0;
        foreach(char c in jewels){
            foreach(char s in stones){
                if(c == s) ans++;
            }
        }
        return ans;
    }
}

// Complexity Analysis
// Time Complexity O(m * n) Jewels length m * stones length n
// Space Complexity O(1)