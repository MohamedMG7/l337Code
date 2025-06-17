public class Solution {
    public int LengthOfLastWord(string s) {
        string[] sp = s.Trim().Split(" ");
        return sp[^1].Length;
    }
}

// Time Complexity O(n) worst case is we need to traverse the whole string
// space complexity O(1) no array for splitted string