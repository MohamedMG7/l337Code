public class Solution {
    public int LengthOfLastWord(string s) {
        string[] sp = s.Trim().Split(" ");
        return sp[^1].Length;
    }
}

// time complexity O(n) => Trim and split takes O(n) => n + n = 2n => O(n)
// space complexity O(m) m are words in the array after spliting the string s