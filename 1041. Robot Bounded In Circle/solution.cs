public class Solution
{
    public bool IsRobotBounded(string instructions)
    {
        int dir = 0;
        int x = 0;
        int y = 0;

        foreach (char c in instructions)
        {
            if (c == 'G')
            {
                switch (dir)
                {
                    case 0: y++; break;
                    case 1: x++; break;
                    case 2: y--; break;
                    case 3: x--; break;
                }
            }
            else if (c == 'L')
            {
                dir = (dir + 3) % 4;
            }
            else
            {
                dir = (dir + 1) % 4;
            }
        }

        if (dir != 0)
        {
            return true;
        }
        if (x == 0 && y == 0)
        {
            return true;
        }
        return false;
    }
}

// Time Complexity O(n) where n is the number of instructions
// Space Complexity O(1) 

// this is a more compact solution that use vector rotation no switch with the same complexity analysis

// public bool IsRobotBounded(string instructions) {
//         int x = 0, y = 0;
//         int dx = 0, dy = 1; // facing North

//         foreach (char c in instructions) {
//             if (c == 'G') { x += dx; y += dy; }
//             else if (c == 'L') { (dx, dy) = (-dy,  dx); }
//             else {               (dx, dy) = ( dy, -dx); } // 'R'
//         }

//         return (x == 0 && y == 0) || !(dx == 0 && dy == 1);
//     }