public class Solution
{
    public long SumAndMultiply(int n)
    {
        long x = 0;
        int sum = 0;

        foreach (char c in n.ToString())
        {
            int digit = c - '0';

            if (digit != 0)
            {
                x = x * 10 + digit;
                sum += digit;
            }
        }

        return x * sum;
    }
}

// complexity analysis
// time complexity O(n)
// space complexity O(1)