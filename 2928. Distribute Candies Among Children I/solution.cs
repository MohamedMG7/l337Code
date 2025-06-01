public class Solution {
    public int DistributeCandies(int n, int limit) {
        int a,b,c;
        int number_of_combinations = 0;
        for(int i = 0; i <= limit; i++){
            for(int j = 0; j <= limit; j++){
                a = i;
                b = j;
                c = n - i - j; 
                if(c >= 0 && c <= limit){
                    number_of_combinations++;
                }
            }

        }
        return number_of_combinations;
    }
}

// Complexity analysis
// Time complexity: O(limit^2)
// Space complexity: O(1)
