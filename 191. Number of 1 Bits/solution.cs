public class Solution {
    public int HammingWeight(int n) {
        return Convert.ToString(n,2).Count(x => x == '1');
    }
}

// Complexity Analysis
// Time complexity: O(log n) where n is the input number. This is because we convert the number to a binary string, which takes O(log n) time.
// Space complexity: O(log n) for the binary string representation of the number.