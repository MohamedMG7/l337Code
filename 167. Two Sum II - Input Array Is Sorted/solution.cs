public class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {

        int left = 0;
        int right = numbers.Length - 1;
        while (left < right)
        {
            int sum = numbers[left] + numbers[right];
            if (sum == target)
            {
                return new int[] { left + 1, right + 1 };
            }
            else if (sum > target)
            {
                right--;
            }
            else
            {
                left++;
            }
        }
        return new int[] { };
    }
}
// complexity is O(n) where n is the number of elements in the array - space complexity is O(1) because we are not using any extra space
// this problem is a variation of the two sum problem where the input array is sorted
// since the elements are sorted we can use two pointers technique to find the two numbers that sum to the target
// this can be solved by hashmap also with space complexity O(n) but we do not need to use extra space for that
// it can also be solved by binary search but that will be O(n log n) which is not optimal
// sample for the binary search solution
// for (int i = 0; i < numbers.Length; i++) {
//     int left = i + 1, right = numbers.Length - 1;
//     int complement = target - numbers[i];
//     while (left <= right) {
//         int mid = left + (right - left) / 2;
//         if (numbers[mid] == complement) {
//             return new int[] { i + 1, mid + 1 };
//         } else if (numbers[mid] < complement) {
//             left = mid + 1;
//         } else {
//             right = mid - 1;
//         }
//     }
// }
// we fix one element and then use binary search to find the other element