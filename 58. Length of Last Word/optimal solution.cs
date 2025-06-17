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

// time complexity O(n) => Trim and split takes O(n) => n + n = 2n => O(n)
// space complexity O(m) m are words in the array after spliting the string s