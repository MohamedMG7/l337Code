public class Solution {
    public string ToLowerCase(string s) {
        char[] result = new char[s.Length];

        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            result[i] = (c >= 'A' && c <= 'Z') ? (char)(c + 32) : c;
        }

        return new string(result);
    }
}

// Time Complexity O(n)
// Space Complexity O(n) ToLower Function creates another string to hold converted String
// i wrote an article on linkedin for this solution deep dive in ToLower VS ASCII Based solution Performacnce
// link: 