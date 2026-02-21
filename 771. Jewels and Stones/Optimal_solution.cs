public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        bool[] isJewel = new bool[128];

        foreach (char j in jewels) {
            isJewel[j] = true;
        }

        int ans = 0;
        foreach (char s in stones) {
            if (isJewel[s]) ans++;
        }

        return ans;
    }
}

// Complexity Analysis
// Time Complexity O(m + n)
// Space Complexity O(1)

// using ascii codes to determine which character is jewel give us the O(1) space complexity
// and the use of hashset which have a lookup complexity of O(1) lower the time complexity to O(m + n)