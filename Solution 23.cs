public class Solution {
    public int MaximumValueSum(int[][] board) {
        int m = board.Length;
        int n = board[0].Length;
        int[] rowMax = new int[m];
        int[] colMax = new int[n];
        int maxSum = int.MinValue;

        for (int i = 0; i < m; i++) {
            rowMax[i] = int.MinValue;
            for (int j = 0; j < n; j++) {
                rowMax[i] = Math.Max(rowMax[i], board[i][j]);
            }
        }

        for (int j = 0; j < n; j++) {
            colMax[j] = int.MinValue;
            for (int i = 0; i < m; i++) {
                colMax[j] = Math.Max(colMax[j], board[i][j]);
            }
        }

        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                for (int k = 0; k < m; k++) {
                    if (i == k) {
                        continue;
                    }
                    for (int l = 0; l < n; l++) {
                        if (j == l) {
                            continue;
                        }
                        maxSum = Math.Max(maxSum, board[i][j] + board[k][l] + board[m-i-1][n-j-1]);
                    }
                }
            }
        }

        return maxSum;
    }
}
