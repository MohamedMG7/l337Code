public class Solution
{
    public bool IsValid(string s)
    {
        Stack<char> st = new Stack<char>();

        Dictionary<char, char> bracketPairs = new Dictionary<char, char> {
            { ')', '(' },
            { ']', '[' },
            { '}', '{' }
        };

        foreach (char c in s)
        {
            if (bracketPairs.ContainsValue(c))
            {
                st.Push(c);
            }
            else if (bracketPairs.ContainsKey(c))
            {
                if (st.Count == 0 || st.Pop() != bracketPairs[c])
                {
                    return false;
                }
            }
        }

        return st.Count == 0;
    }
}

// complexity O(n) where n is the number of characters in string s
// using dictinoaries is better than using array because the lookup time is O(1)