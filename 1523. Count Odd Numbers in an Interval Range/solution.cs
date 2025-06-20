public class Solution {
    public int CountOdds(int low, int high) {
        int n = high - low;
        return low % 2 == 1 || high % 2 == 1 ? (n / 2) + 1 : (n / 2); 

        // shorter solution
        //return (high + 1) / 2 - (low / 2);
    }
}

// Time Complexity O(1)
// Space Complexity O(1)

// idea is simple here the math formula is n / 2 is the count of odd numbers between 2 even numbers (inclusive) but if one of the 2 numbers is odd we need to add 1
// it is a math problem so complexity is constant