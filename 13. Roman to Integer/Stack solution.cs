public class Solution {
    public int RomanToInt(string s) {
        var RomanNumbers = new Dictionary<char, int>{
            {'I',1},
            {'V',5},
            {'X',10},
            {'L',50},
            {'C',100},
            {'D',500},
            {'M',1000}
        };

        Stack<int> stack = new Stack<int>();
        int result = 0;

        foreach (char c in s) {
            int currentVal = RomanNumbers[c];

            // If there's a value in the stack and it's less than current, it's a subtractive pair
            if (stack.Count > 0 && stack.Peek() < currentVal) {
                int prevVal = stack.Pop();
                result += (currentVal - prevVal);
            }
            else {
                stack.Push(currentVal);
            }
        }

        // Add any remaining values in the stack
        while (stack.Count > 0) {
            result += stack.Pop();
        }

        return result;
    }
}

// time complexity O(n) ----> chars in the string (s)
// space complexity O(n) ---> elements get pushed into the stack
// this algorithm is not optimized because all the elements get pushed to the stack even if it is not subtractive 