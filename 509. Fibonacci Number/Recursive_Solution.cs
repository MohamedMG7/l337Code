public class Solution {
    public int Fib(int n) {
        if(n <= 1) return n;
        return Fib(n-1) + Fib(n-2);
    }
}

// Time Complexity O(2 ^ n) each recursion spawn 2 calls
// space complexity is as deep as the stack calls which is n here so O(n)