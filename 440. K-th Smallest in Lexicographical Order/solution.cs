public class Solution {
    public int FindKthNumber(int n, int k) {
        int curr = 1;
        k -= 1; 

        while (k > 0) {
            long steps = CountSteps(n, curr, curr + 1);

            if (steps <= k) {
                curr += 1;
                k -= (int)steps;
            } else {
                curr *= 10;
                k -= 1;
            }
        }

        return curr;
    }

   
    private long CountSteps(int n, long curr, long next) {
        long steps = 0;
        while (curr <= n) {
            steps += Math.Min(n + 1L, next) - curr;
            curr *= 10;
            next *= 10;
        }
        return steps;
    }
}

//time complexity: O(log n * log n) - the outer loop runs log n times and the inner loop runs log n times as well
//space complexity: O(1)