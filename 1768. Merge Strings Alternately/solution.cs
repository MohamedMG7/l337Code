public class Solution {
    public string MergeAlternately(string word1, string word2) {
        // int i = 0, j = 0, m = word1.Length, n = word2.Length;
        // StringBuilder res = new(), w1 = new(word1), w2 = new(word2);

        // while (i < m && j < n)
        // {
        //     res.Append(w1[i++]);
        //     res.Append(w2[j++]);
        // }

        // while (i < m)
        //     res.Append(w1[i++]);
        // while (j < n)
        //     res.Append(w2[j++]);
        // return res.ToString();


        // shorter solution
        StringBuilder res = new();
        int m = word1.Length, n = word2.Length;

        for (int i = 0; i < Math.Max(m, n); i++) {
            if (i < m) res.Append(word1[i]);
            if (i < n) res.Append(word2[i]);
        }

        return res.ToString();
    }
}

// time complexity O(m+n) m is the first string and n is the second one
// space complexity O(m+n) same as time compelxity
// using stringBuilder is better than using string because string is immutable 
// so every time we add new char to string we create new string in the memory
// but string builder is more dynamic so less memory complexity and less time complexity
