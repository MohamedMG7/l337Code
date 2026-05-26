public class Solution {
    public int LongestCommonPrefix(int[] arr1, int[] arr2) {
        HashSet<int> prefixes = new HashSet<int>();

        for (int i = 0; i < arr1.Length; i++)
        {
            int x = arr1[i];

            while (x > 0)
            {
                prefixes.Add(x);
                x /= 10;
            }
        }

        int maxLength = 0;

        for(int i = 0; i < arr2.Length; i++){
            int x = arr2[i];
            while(x > 0){
                if(prefixes.Contains(x)){
                    maxLength = Math.Max(maxLength, x.ToString().Length);
                    break;
                }
                x /= 10;
            }
        }

        return maxLength;
    }
}

// Time Complexity: O((n + m) * d)
// n = arr1.Length, m = arr2.Length, d = max number of digits.
// We process up to d prefixes for each number in both arrays.
// Space Complexity: O(n * d)
// We store up to d prefixes for each number in arr1.