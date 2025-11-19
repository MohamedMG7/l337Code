public class Solution {
    public void GameOfLife(int[][] board) {
        if (board == null || board.Length == 0) return;

        List<(int x, int y)> changing = new List<(int x, int y)>();

        for (int x = 0; x < board.Length; x++) {
            for (int y = 0; y < board[x].Length; y++) {
                int liveNeigbors = CountLiveneighbors(x, y, board);

                
                if (board[x][y] == 0 && liveNeigbors == 3) {
                    changing.Add((x, y));
                } else if (board[x][y] == 1 && (liveNeigbors < 2 || liveNeigbors > 3)) {
                    changing.Add((x, y));
                }
            }
        }

        // apply changes
        foreach (var item in changing) {
            board[item.x][item.y] = board[item.x][item.y] == 1 ? 0 : 1;
        }
    }

    private int CountLiveneighbors(int x, int y, int[][] board) {
        int rows = board.Length;
        int aliveNeighbors = 0;

        for (int r = -1; r <= 1; r++) {       
            for (int c = -1; c <= 1; c++) {   
                if (r == 0 && c == 0) continue; 

                int nr = x + r; 
                int nc = y + c; 

                if (nr < 0 || nr >= rows) continue;
                if (nc < 0) continue;
                if (nc >= board[nr].Length) continue; 

                if (board[nr][nc] == 1) aliveNeighbors++;
            }
        }

        return aliveNeighbors;
    }

}

// Complexity Analysis
// Time Complexity O(m * n) where m is number of rows and n is number of columns
// Space Complexity is O(M * N) in the worst case due to the 'changing' list.