public class Solution
{
    public IList<int> LexicalOrder(int n)
    {

        // DFS ALgorithm (Depth First Search)
        List<int> result = new List<int>();
        int curr = 1;
        for (int i = 0; i < n; i++)
        {
            result.Add(curr);

            if (curr * 10 <= n)
            {
                curr *= 10;
            }
            else if (curr % 10 != 9 && curr + 1 <= n)
            {
                curr += 1;
            }
            else
            {
                while (curr % 10 == 9 || curr + 1 > n)
                {
                    curr /= 10;
                }
                curr += 1;
            }
        }

        return result;
    }
}

// Time Complexity: O(n)
// Space Complexity: O(1) excluding the output list
// Explanation: The algorithm generates numbers in lexicographical order by simulating a depth-first search (DFS)
// traversal of a tree where each node represents a digit. It starts from 1 and explores deeper by multiplying by 10,
// then moves to the next number when it reaches the end of a branch. The while loop ensures that it backtracks correctly when necessary.

// algorithm in steps
// 1. Start with the first number (1).
// 2. Multiply by 10 to go deeper in the tree (e.g., from 1 to 10).
// 3. If you can't go deeper (e.g., 10 > n), check if you can increment the last digit (e.g., from 10 to 11).
// 4. If you can't increment (e.g., 19), backtrack by dividing by 10 until you can increment.
// 5. Repeat until you have generated all numbers up to n.