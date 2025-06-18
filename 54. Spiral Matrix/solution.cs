public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
         List<int> result = new List<int>();
        if (matrix == null || matrix.Length == 0) return result;

        int top = 0;
        int bottom = matrix.Length - 1;
        int left = 0;
        int right = matrix[0].Length - 1;

        while (top <= bottom && left <= right) {
            // Traverse from left to right
            for (int i = left; i <= right; i++) {
                result.Add(matrix[top][i]);
            }
            top++;

            // Traverse from top to bottom
            for (int i = top; i <= bottom; i++) {
                result.Add(matrix[i][right]);
            }
            right--;

            // Traverse from right to left
            if (top <= bottom) {
                for (int i = right; i >= left; i--) {
                    result.Add(matrix[bottom][i]);
                }
                bottom--;
            }

            // Traverse from bottom to top
            if (left <= right) {
                for (int i = bottom; i >= top; i--) {
                    result.Add(matrix[i][left]);
                }
                left++;
            }
        }

        return result;
    }
}

// Time Complexity O(m*n)
// Space Complexity O(1) can also be considered O(n) if we consider the result but the traverse it self is O(1)