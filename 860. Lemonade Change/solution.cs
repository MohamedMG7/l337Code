public class Solution {
    public bool LemonadeChange(int[] bills) {
        int fives = 0;
        int tens = 0;

        foreach (int bill in bills) {
            if (bill == 5) {
                fives++;
            }
            else if (bill == 10) {
                if (fives == 0) return false; 
                fives--;
                tens++;
            }
            else { // bill == 20
                if (tens > 0 && fives > 0) {
                    tens--;
                    fives--;
                }
                else if (fives >= 3) {
                    fives -= 3;
                }
                else {
                    return false;
                }
            }
        }
        return true;
    }
}
// Time complexity: O(n) where n is the number of bills
// Space complexity: O(1) since we are using a constant amount of space for fives and tens counters