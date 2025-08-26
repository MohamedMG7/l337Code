public class Solution {
    public int CalPoints(string[] operations) {
        List<int> scores = new List<int>();

        foreach (string op in operations) {
            if (op == "+") {
                int sum = scores[^1] + scores[^2]; // last + second last
                scores.Add(sum);
            } else if (op == "D") {
                scores.Add(scores[^1] * 2);
            } else if (op == "C") {
                scores.RemoveAt(scores.Count - 1);
            } else {
                scores.Add(int.Parse(op));
            }
        }

        int ans = 0;
        foreach (int score in scores) {
            ans += score;
        }
        return ans;
    }
}

// Time Complexity O(n)
// Space Complexity O(n)
