public class Solution {
    public int MinimumCost(int[] cost) {
        int ans = 0;
        int[] sortedCost = cost.OrderByDescending(x => x).ToArray();
        int counter = 0;
        for(int i = 0 ; i < sortedCost.Length; i++){
            if(counter == 2){
                counter = 0;
                continue;
            } 
            ans += sortedCost[i];
            counter++;
        }   
        return ans;
    }
}

// Complexity analysis
// time complexity O(n log n) because of the sorting
// space complexity O(n) also sorting makes a new sorted array