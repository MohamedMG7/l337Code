public class Solution
{
    public IList<bool> GetResults(int[][] queries)
    {
        int limit = 0;

        foreach (int[] query in queries)
        {
            limit = Math.Max(limit, query[1]);
        }

        // Sentinel after the biggest possible x.
        limit += 1;

        SortedSet<int> obstacles = new();
        obstacles.Add(0);
        obstacles.Add(limit);

        SegmentTree seg = new SegmentTree(limit + 1);

        // gap ending at 0 is 0
        seg.Update(0, 0);

        // initially, the whole area is free from 0 to limit
        seg.Update(limit, limit);

        List<bool> ans = new();

        foreach (int[] query in queries)
        {
            if (query.Length == 2)
            {
                int p = query[1];

                int prev = obstacles.GetViewBetween(0, p).Max;
                int next = obstacles.GetViewBetween(p, limit).Min;

                obstacles.Add(p);

                // New gap ending at p
                seg.Update(p, p - prev);

                // The old gap ending at next changed
                seg.Update(next, next - p);
            }
            else
            {
                int x = query[1];
                int sz = query[2];

                int prev = obstacles.GetViewBetween(0, x).Max;

                int bestGapEndingBeforeX = seg.Query(0, x);

                int tailGap = x - prev;

                int biggestGap = Math.Max(bestGapEndingBeforeX, tailGap);

                ans.Add(biggestGap >= sz);
            }
        }

        return ans;
    }
}

public class SegmentTree
{
    private readonly int n;
    private readonly int[] tree;

    public SegmentTree(int size)
    {
        n = 1;

        while (n < size)
        {
            n *= 2;
        }

        tree = new int[n * 2];
    }

    public void Update(int index, int value)
    {
        int pos = index + n;

        tree[pos] = value;

        pos /= 2;

        while (pos >= 1)
        {
            tree[pos] = Math.Max(tree[pos * 2], tree[pos * 2 + 1]);
            pos /= 2;
        }
    }

    public int Query(int left, int right)
    {
        left += n;
        right += n;

        int result = 0;

        while (left <= right)
        {
            if (left % 2 == 1)
            {
                result = Math.Max(result, tree[left]);
                left++;
            }

            if (right % 2 == 0)
            {
                result = Math.Max(result, tree[right]);
                right--;
            }

            left /= 2;
            right /= 2;
        }

        return result;
    }
}

// Complexity Analysis
//
// Let q = queries.Length.
// Let L = max query[1] + 2, which represents the coordinate range used by the segment tree.
//
// First, we scan all queries to find the maximum coordinate, which takes O(q).
// Creating the segment tree takes O(L) space and O(L) initialization time.
//
// For an obstacle insertion query [1, p]:
// - Finding the previous and next obstacles in SortedSet costs O(log q).
// - Inserting the new obstacle costs O(log q).
// - Updating the segment tree twice costs O(log L).
// So each insertion query costs O(log q + log L).
//
// For a check query [2, x, sz]:
// - Finding the previous obstacle before x costs O(log q).
// - Querying the maximum gap in the segment tree over [0, x] costs O(log L).
// - The remaining calculations are O(1).
// So each check query costs O(log q + log L).
//
// Since there are q queries total, processing all queries costs:
// O(q * (log q + log L)).
//
// Including segment tree creation, the final time complexity is:
// O(L + q * (log q + log L)).
//
// Space usage:
// - SortedSet stores up to q obstacles: O(q)
// - Segment tree stores O(L) values
// - Answer list stores up to q booleans: O(q)
//
// Final space complexity:
// O(L + q)