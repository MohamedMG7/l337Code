public class Solution
{
    public int[] CountBits(int n)
    {
        int[] ans = new int[n + 1];

        for (int i = 1; i <= n; i++)
        {
            ans[i] = ans[i / 2] + (i % 2);
        }

        return ans;
    }
}

// Complexity Analysis:
// Time Complexity: O(n)
// We loop from 1 to n once, and each calculation takes O(1).
//
// Space Complexity: O(n)
// We store the answer for every number from 0 to n in the ans array.


// Idea:
// ans[i] stores the number of 1 bits in the binary representation of i.
//
// To calculate ans[i], we reuse a smaller already-solved number: i / 2.
// In binary, dividing by 2 removes the last bit.
//
// Example:
// 13 = 1101
// 13 / 2 = 6 = 110
//
// So 13 has the same number of 1s as 6,
// plus the last bit of 13.
//
// The last bit is found using i % 2:
// - if i is even, last bit is 0
// - if i is odd, last bit is 1
//
// Therefore:
// ans[i] = ans[i / 2] + (i % 2)
//
// This is dynamic programming because we build the answer for i
// using a previously calculated answer for i / 2.

