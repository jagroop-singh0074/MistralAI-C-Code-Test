public class Solution {
    public IList<int> ValidSequence(string word1, string word2) {
        int m = word1.Length;
        int n = word2.Length;
        List<int>[] dp = new List<int>[n + 1];
        for (int i = 0; i <= n; i++) {
            dp[i] = new List<int>();
        }
        for (int i = 0; i < m; i++) {
            for (int j = n - 1; j >= 0; j--) {
                if (word1[i] == word2[j] || (j < n - 1 && word1[i] == word2[j + 1])) {
                    if (j == n - 1 || dp[j + 1].Count > 0) {
                        dp[j].Add(i);
                    }
                }
            }
        }
        dp[0].Reverse();
        return dp[0].Count > 0 ? dp[0] : new List<int>();
    }
}
