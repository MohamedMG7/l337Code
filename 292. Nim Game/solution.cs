public class Solution
{
    public bool CanWinNim(int n)
    {
        return n % 4 != 0;
    }
}

// Complexity Analysis
// Time Complexity O(1)
// Space Complexity O(1)

// the idea here is simple if we have 4 stones left and it is our turn we will lose 100% anything else we can when
// so we do mod to get if the number is a multiple of 4 or not if it is then we lose anything else is winning