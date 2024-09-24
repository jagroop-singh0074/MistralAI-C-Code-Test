public class Solution {
    public int MaxValue(int[] nums, int k) {
        int n = nums.Length;
        int[] dp = new int[1 << n];
        for (int mask = 0; mask < (1 << n); mask++) {
            int count = BitCount(mask);
            if (count <= k) {
                for (int i = 0; i < n; i++) {
                    if ((mask & (1 << i)) != 0) {
                        dp[mask] |= nums[i];
                    }
                }
            }
        }
        int res = 0;
        for (int mask = 0; mask < (1 << n); mask++) {
            if (BitCount(mask) == k) {
                res = Math.Max(res, dp[mask] ^ dp[(1 << n) - 1 - mask]);
            }
        }
        return res;
    }

    private int BitCount(int mask) {
        int count = 0;
        while (mask > 0) {
            count += mask & 1;
            mask >>= 1;
        }
        return count;
    }
}
