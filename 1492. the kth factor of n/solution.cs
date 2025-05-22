public class Solution
{

    // first solution
    public int KthFactor(int n, int k)
    {
        //get the factors
        List<int> factors = new List<int>();
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                factors.Add(i);
            }
        }

        if (factors.Count() < k)
        {
            return -1;
        }

        return factors[k - 1];
        //complexity
        // O(n) Time Complexity
        // O(n) Space Complexity
    }

    //optimized solution
    public int KthFactor(int n, int k)
    {
        // we do not need to store the factors we just need to track the index of the factor
        //so when we reach the k factor we can return it
        int Count = 0;

        for (int i = 1; i <= (n/2); i++) // why n/2? because the biggest factor is n/2 always the the next one will be n itself so this trick for less iterations
        {
            if (n % i == 0)
            {
                Count++;

                if (Count == k) // NESTED IF so we check only when there is a factor so less checks
                {
                    return i;
                }
            }
        }

        // check if k is the n itself => the last index
        Count++;
        if (Count == k) {
            return n;
        }

        return -1;
        //complexity
        // O(n) Time Complexity but n here is half of n given. but still the right annotation is O(n)
        // O(1) Space Complexity
    }
}