public class Solution {
    public int[] PlusOne(int[] digits) {
        int pointer = digits.Length - 1;

        while (pointer >= 0) {
            if (digits[pointer] < 9) {
                digits[pointer]++;
                return digits;
            } else {
                digits[pointer] = 0;
                pointer--;
            }
        }
        
        // handling 999 case where we need to add one more element at the end of the array - array is fixed size so we should make a new one with [oldArray.Length + 1]
        int[] result = new int[digits.Length + 1];
        result[0] = 1; 
        return result;
    }
}

// time complexity => O(n) where n is the number of the elements in the array
// space complexity => O(1) if we are using the old array so we doing in-place changes
// but can be O(n) if we creating new array to handle adding one more element
// worst space complexity is O(n)