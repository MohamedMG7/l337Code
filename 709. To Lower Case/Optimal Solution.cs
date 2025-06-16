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