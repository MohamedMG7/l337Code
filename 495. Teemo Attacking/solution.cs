public class Solution {
    public int FindPoisonedDuration(int[] timeSeries, int duration) {
        int ans = 0;
        for(int i = 0; i < timeSeries.Length - 1; i++){
            if(duration < timeSeries[i+1] - timeSeries[i]) ans += duration;
            else {ans += timeSeries[i+1] - timeSeries[i];}
        }
        return ans + duration;
    }
}

// Complexity Analysis
// Time complexity: O(n) where n is the length of the timeSeries array, because
// space complexity: O(1) because we are using a constant amount of space to store the answer and the loop variable.