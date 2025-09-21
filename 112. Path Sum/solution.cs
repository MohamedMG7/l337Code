public class Solution
{
    public bool HasPathSum(TreeNode root, int targetSum)
    {
        if (root == null) return false;

        // If it's a leaf, check if the remaining sum equals this node's value
        if (root.left == null && root.right == null)
            return targetSum == root.val;

        // Otherwise, try left or right with the reduced sum
        int remaining = targetSum - root.val;
        return HasPathSum(root.left, remaining) || HasPathSum(root.right, remaining);
    }
}

// complexity Analysis:
// Time Complexity: O(n) where n is the number of nodes in the tree
// Space Complexity: O(h) where h is the height of the tree, due to recursion stack