public class Solution
{
    public int NumberOfSubmatrices(char[][] grid)
    {
        int rows = grid.Length;
        int cols = grid[0].Length;
        int[,] prefixX = new int[rows, cols];
        int[,] prefixY = new int[rows, cols];
        int count = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                int xValue = grid[i][j] == 'X' ? 1 : 0;
                int yValue = grid[i][j] == 'Y' ? 1 : 0;

                int topX = i > 0 ? prefixX[i - 1, j] : 0;
                int leftX = j > 0 ? prefixX[i, j - 1] : 0;
                int topLeftX = (i > 0 && j > 0) ? prefixX[i - 1, j - 1] : 0;

                int topY = i > 0 ? prefixY[i - 1, j] : 0;
                int leftY = j > 0 ? prefixY[i, j - 1] : 0;
                int topLeftY = (i > 0 && j > 0) ? prefixY[i - 1, j - 1] : 0;

                prefixX[i, j] = topX + leftX - topLeftX + xValue;
                prefixY[i, j] = topY + leftY - topLeftY + yValue;

                if (prefixX[i, j] == prefixY[i, j] && prefixX[i, j] > 0)
                {
                    count++;
                }
            }
        }

        return count;
    }
}

// Complexity Analysis
// time complexity O(rows*columns)
// space complexity O(rows*columns)