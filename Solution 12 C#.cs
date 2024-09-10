public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        double maxSum = double.NegativeInfinity;
        double currSum = 0;
        for (int i = 0; i < nums.Length; i++) {
            currSum += nums[i];
            if (i >= k) {
                currSum -= nums[i - k];
            }
            if (i >= k - 1) {
                maxSum = Math.Max(maxSum, currSum);
            }
        }
        return maxSum / k;
    }
}
