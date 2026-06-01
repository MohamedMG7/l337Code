public class Solution {
    public int MinimumCost(int[] cost) {
        int ans = 0;
        int[] freq = new int[101];
        foreach (int c in cost) {
            freq[c]++;
        }
        int counter = 0;
        for (int price = 100; price >= 1; price--) {
            while (freq[price] > 0) {
                if (counter == 2) {
                    counter = 0;
                } else {
                   ans += price;
                    counter++;
                }

                freq[price]--;
            }
        }
        return ans;
    }
}

// Complexity analysis
// using frequency array we can get this from using normal sorting to O(n + m) where m is the max count and since in constraint we know that m is 100 in worse case so it becomes
// Time Comeplixty O(n + 100) which means O(n) 
// space complexity O(m) and again since m is by consraint max an array with 101 elements so it is can be treated like a constant O(1) 