public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        // first get the number of rows and create a list of lists to hold the values
        IList<IList<int>> triangle = new List<IList<int>>();
        // loop through the number of rows and create a new list for each row
        for (int i = 0; i < numRows; i++) {
            List<int> row = new List<int>();
            // loop through the number of columns in the current row and calculate the value
            for (int j = 0; j <= i; j++) {
                if (j == 0 || j == i) {
                    row.Add(1);
                } else {
                    row.Add(triangle[i - 1][j - 1] + triangle[i - 1][j]);
                }
            }
            triangle.Add(row);
        }   
        return triangle;
    }
}

// Complexity Analysis
// Time complexity: O(numRows^2) because we have a nested loop where the outer
// loop runs numRows times and the inner loop runs up to i times, which in the worst case is numRows.
// Space complexity: O(numRows^2) because we are storing the values of the triangle