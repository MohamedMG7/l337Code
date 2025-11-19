public class Solution {
    public void GameOfLife(int[][] board) {
        if (board == null || board.Length == 0) return;

        int rows = board.Length;

        // ================================
        // 1) First pass: compute next state
        // ================================
        //
        // We do NOT overwrite the board[x][y] completely.
        // Instead, we use:
        //
        // bit-0 = current state  (0 or 1)
        // bit-1 = next state     (0 or 1)
        //
        // This way we can compute the next generation
        // WITHOUT losing the original state required
        // for neighbor checks.
        //
        // board[x][y] = (next << 1) | current
        //
        for (int x = 0; x < rows; x++) {
            for (int y = 0; y < board[x].Length; y++) {

                int aliveNeighbors = CountLiveneighbors(x, y, board);

                // Extract CURRENT state (bit-0)
                int current = board[x][y] & 1;

                // Apply Conway's Game of Life rules:

                // Rule 1 & 3: alive cell survives only with 2 or 3 neighbors
                if (current == 1 && (aliveNeighbors == 2 || aliveNeighbors == 3)) {
                    board[x][y] |= 2; // set bit-1 (next = 1)
                }
                // Rule 4: dead cell becomes alive with exactly 3 neighbors
                else if (current == 0 && aliveNeighbors == 3) {
                    board[x][y] |= 2; // set bit-1 (next = 1)
                }

                // Otherwise next state is 0, so we do nothing
                // (bit-1 stays 0)
            }
        }

        // ========================================
        // 2) Second pass: finalize by shifting bits
        // ========================================
        //
        // Now each cell contains two bits:
        // bit-0: old state
        // bit-1: next state
        //
        // We only want the next state.
        // Shifting right moves bit-1 → bit-0.
        //
        // Example:
        // 00 -> 0
        // 01 -> 0
        // 10 -> 1
        // 11 -> 1
        //
        for (int x = 0; x < rows; x++) {
            for (int y = 0; y < board[x].Length; y++) {
                board[x][y] >>= 1; // new current state
            }
        }
    }

    // ==============================================
    // Count neighbors using only bit-0 (original state)
    // ==============================================
    private int CountLiveneighbors(int x, int y, int[][] board) {
        int rows = board.Length;
        int alive = 0;

        // Check all 8 directions using offsets
        for (int r = -1; r <= 1; r++) {
            for (int c = -1; c <= 1; c++) {

                if (r == 0 && c == 0) continue; // skip the cell itself

                int nr = x + r; // neighbor row
                int nc = y + c; // neighbor column

                // Validate row bounds
                if (nr < 0 || nr >= rows) continue;

                // Validate column bounds for jagged arrays
                if (nc < 0 || nc >= board[nr].Length) continue;

                // Check ONLY original state (bit-0)
                if ((board[nr][nc] & 1) == 1)
                    alive++;
            }
        }

        return alive;
    }
}


// Complexity Analysis
// Time Complexity O(m * n) where m is number of rows and n is number of columns
// Space Complexity O(1)

// this solution is optimal in terms of space as it uses in-place state encoding to avoid extra space usage
// simply we store the next state in the 2nd bit of each cell