public class Solution {
    public int NumberOfSpecialChars(string word) {
        HashSet<char> lower = new();
        HashSet<char> upper = new();
        for(int i = 0; i < word.Length; i++){
            if(char.IsUpper(word[i])) upper.Add(char.ToLower(word[i]));
            else lower.Add(word[i]);
        }
        return  upper.Intersect(lower).Count();
    }
}

// complexity analysis
// time complexity O(n)
// space complexity O(1) becuase the maximum count we gonna store is 52 = 26 lowercase + 26 uppercase. so it is constrained