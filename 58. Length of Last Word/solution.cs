public class Solution {
    public int LengthOfLastWord(string s) {
        int length = 0, i = s.Length - 1;

        // Skip trailing spaces
        while (i >= 0 && s[i] == ' ')
            i--;

        // Count the last word
        while (i >= 0 && s[i] != ' ')
        {
            length++;
            i--;
        }

        return length;
    }
}

// Time Complexity O(n) worst case is we need to traverse the whole string
// space complexity O(1) no array for splitted string