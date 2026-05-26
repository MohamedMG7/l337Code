public class Solution {
    public int NumberOfSpecialChars(string word) {
        bool[] lower = new bool[26];
        bool[] upper = new bool[26];

        foreach (char ch in word)
        {
            int index = char.ToLower(ch) - 'a';

            if (char.IsLower(ch))
            {
                lower[index] = true;
            }
            else
            {
                upper[index] = true;
            }
        }

        int count = 0;

        for (int i = 0; i < 26; i++)
        {
            if (lower[i] && upper[i])
            {
                count++;
            }
        }

        return count;
    }
}

// complexity analysis
// this solution has the same compelxity as hashset solution so no difference on big o. bit using arraies here 
// gives less overhead instead of using a general purpose data structure. 
// but to be honest it is not worth it to think about it unless you do not have a life.
// time complexity O(n)
// space complexity O(1)