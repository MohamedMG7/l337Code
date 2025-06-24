public class Solution {
    public bool CanMakeArithmeticProgression(int[] arr) {
        Array.Sort(arr);
        int diff = arr[1] - arr[0];
        for(int i = 1; i < arr.Length - 1; i++){
            if(arr[i + 1] - arr[i] != diff){
                return false;
            }
        }
        return true;
    }
}

// Time Complexity O(n log n) looping O(n), sorting O(n log n)
// space complexity O(log n) Array.sort uses introsort which try different algorithms like quick sort
// sorting is done in-place so no additional space for creating new array and merging or partioning
// but the complexity is in the recursive call stack in introsort

// introsort > introspective sort
// has 3 algorithms Heapsort, insertion sort and quicksort
// worst space compelxity is O(log n) for the quick sort and best is O(1) for heap and insertion
// worst time Complexity is O(n log n) 

// Part	            Best	        Average	        Worst	        Space
// Quicksort	    O(n log n)	    O(n log n)	    O(n²)	        O(log n)
// Heapsort	        O(n log n)	    O(n log n)	    O(n log n)	    O(1)
// Insertion Sort	O(n)	        O(n²)	        O(n²)	        O(1)
// Introsort	    O(n log n)	    O(n log n)	    O(n log n)	    O(log n)

// introsort was invented to avoid the O(n^2) of the quicksort
// quick sort is good in practice but poor pivot choice can have significant effect on the algorithm complexity
// so it does fallback to heapsort if quick sort it too complex