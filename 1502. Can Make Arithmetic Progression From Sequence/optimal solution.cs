public class Solution {
    public bool CanMakeArithmeticProgression(int[] arr) {
        // If the array has 2 or fewer elements, it's always an arithmetic progression
        if (arr.Length <= 2) return true;

        // Initialize min and max values and calculate the last index
        var (min, max, last) = (int.MaxValue, int.MinValue, arr.Length - 1);

        // Find the minimum and maximum value in the array
        for (int i = 0; i < arr.Length; i++) {
            min = Math.Min(min, arr[i]);
            max = Math.Max(max, arr[i]);
        }

        // If the total range is not evenly divisible by the number of steps, return false
        if ((max - min) % last != 0) return false;

        // Calculate the common difference (delta) of the expected arithmetic progression
        int delta = (max - min) / last;

        // If delta is 0, all elements must be equal, which is a valid progression
        if (delta == 0) return true;

        // Try to rearrange elements to match the expected values in the arithmetic sequence
        for (int i = 0; i < arr.Length;) {
            // Calculate the value that should be at index i
            int expectedVal = min + (i * delta);

            // If current value is correct, move to next
            if (arr[i] == expectedVal) { 
                i++; 
                continue; 
            }

            // Check if arr[i] fits into the arithmetic progression
            // Calculate the correct position `pos` for arr[i]
            int pos = Math.DivRem(arr[i] - min, delta, out int inSequence);

            // If the element is not on a valid arithmetic position (not divisible), return false
            if (inSequence != 0) return false;

            // If it maps to an already-processed index or it's a duplicate, return false
            if (pos < i || arr[pos] == arr[i]) return false;

            // Swap current element with the element at its correct position
            (arr[i], arr[pos]) = (arr[pos], arr[i]);
        }

        // If all elements are placed correctly, return true
        return true;
    }
}

// Time Complexity O(n)
// Space Complexity O(1)