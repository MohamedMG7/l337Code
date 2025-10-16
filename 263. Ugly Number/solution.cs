public class Solution
{
    public bool IsUgly(int n)
    {
        if (n <= 0) return false;

        int[] primes = { 2, 3, 5 };

        foreach (int p in primes)
        {
            while (n % p == 0) // this ensures that i get the factors
                n /= p;
        }

        return n == 1;
    }
}

// Complexity Analysis:
// Time Complexity: O(log n) in the worst case, where n is the input number. This is because we are dividing n by 2, 3, or 5 repeatedly.
// Space Complexity: O(1) since we are using a constant amount of space.