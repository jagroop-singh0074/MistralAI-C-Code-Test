public class Solution {
    public bool IsMatch(string s, string p) {
        int m = s.Length;
        int n = p.Length;
        bool[,] dp = new bool[m + 1, n + 1];
        dp[0, 0] = true;
        for (int i = 0; i <= m; i++) {
            for (int j = 1; j <= n; j++) {
                if (p[j - 1] == '*') {
                    dp[i, j] = dp[i, j - 2] || (i > 0 && dp[i - 1, j] && (s[i - 1] == p[j - 2] || p[j - 2] == '.'));
                } else {
                    dp[i, j] = i > 0 && dp[i - 1, j - 1] && (s[i - 1] == p[j - 1] || p[j - 1] == '.');
                }
            }
        }
        return dp[m, n];
    }
}
