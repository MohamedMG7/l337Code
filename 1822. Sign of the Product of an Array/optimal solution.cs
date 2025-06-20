public class Solution {
    public int ArraySign(int[] nums) {
        int sign = 1;
        foreach(int n in nums){
            if(n == 0){
                return 0;
            }
            if(n < 0) sign *= -1;
            else sign *= 1;
        }

        return sign > 0 ? 1 : -1;
    }
    // Time Complexity O(n)
    // Space Complexity O(1)
    // 1- we do not need to calculate the product it self this will cose more memory and computation we can only keep track of the sign
    // 2- we do not need to add nums.Contains(0) like the prevoius solution this will loop over the array once again this will cose more computation although it does not chagne the complexity because 
    // O(n+n) => O(2n) => O(n) but complexity analysis is not the only indicaiton on algorithm performance - it measures the performance with input relation
}