public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;

        int[] count = new int[26];
        foreach (char c in s)
            count[c - 'a']++;

        foreach (char c in t)
            count[c - 'a']--;

        foreach (int val in count)
            if (val != 0) return false;

        return true;
    }
}

// Time Complexity O(n) loop over chars in s and t
// why not O(n+m) because it is anagram problem so n = m in Length
// n + n = 2n => O(n)
// if there was no anagram constrain and we were comparing 2 strings it would be O(m+n)
// space complexity O(1) because of fixed array to 26 elements