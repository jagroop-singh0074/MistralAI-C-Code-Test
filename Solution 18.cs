public class Solution {
    public int MaxScore(int[,] grid) {
        int m = grid.GetLength(0);
        int n = grid.GetLength(1);
        int[] dp = new int[1 << n];
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                for (int k = (1 << n) - 1; k >= 0; k--) {
                    if ((k & (1 << j)) != 0) {
                        dp[k] = Math.Max(dp[k], dp[k ^ (1 << j)] + grid[i, j]);
                    }
                }
            }
        }
        return dp[(1 << n) - 1];
    }
}
