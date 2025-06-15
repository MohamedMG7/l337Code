public class Solution {
    public int RomanToInt(string s) {
        var RomanNumbers = new Dictionary<char, int> {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        int ans = 0;
        int lastVal = 0;

        for (int i = s.Length - 1; i >= 0; i--) {
            int currentVal = RomanNumbers[s[i]];

            if (currentVal < lastVal) {
                ans -= currentVal;
            } else {
                ans += currentVal;
            }

            lastVal = currentVal;
        }

        return ans;
    }
}


// Time Complexity O(n) ----> chars in string(s)
// Space Complexity is O(1)