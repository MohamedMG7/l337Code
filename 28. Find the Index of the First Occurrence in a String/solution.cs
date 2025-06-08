public class Solution {
    public int StrStr(string haystack, string needle) {
        if (needle == "") return 0;

        for (int i = 0; i <= haystack.Length - needle.Length; i++) {
            if (haystack.Substring(i, needle.Length) == needle) {
                return i;
            }
        }

        return -1;
    }

    // can also use IndexOf (maiive string matching algorithm) built-in function with complexity O(n*m)
    // there are other algorithms to solve this as well 

}