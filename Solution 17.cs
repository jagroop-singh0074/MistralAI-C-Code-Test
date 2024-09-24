public class Solution {
    public int[] GetFinalState(int[] nums, int k, int multiplier) {
        int mod = (int)(1e9 + 7);
        for (int i = 0; i < k; i++) {
            int min_val = nums.Min();
            int min_index = Array.IndexOf(nums, min_val);
            nums[min_index] = (int)(((long)min_val * multiplier) % mod);
        }
        return nums;
    }
}
