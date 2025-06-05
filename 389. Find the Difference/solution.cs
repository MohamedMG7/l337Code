public class Solution {
    public char FindTheDifference(string s, string t) {
        int res = 0;

        foreach (char c in s)
            res ^= c;

        foreach (char c in t)
            res ^= c;

        return (char)res;
    }
}