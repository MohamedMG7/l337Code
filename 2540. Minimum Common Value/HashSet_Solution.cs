public class Solution {
    public int GetCommon(int[] nums1, int[] nums2) {
        HashSet<int> unique = [..nums1]; // colllection expression
        
        foreach(int x in nums2){
            if(unique.Contains(x)) return x;
        }

        return -1;
    }
}

// this takes advantage of the sorted arrays and fast lookups in sets. complexity is similar to the pointers approach, better time complexity than bruteforce and same space complexity
// time complexity O(n + m) even when average lookup in set is O(1) we still loop over nums2 with the .Contains()
// space complexity O(1)