public class Solution {
    public int LongestOnes(int[] nums, int k) {
        int i = 0;
        int j = 0;
        int maxLength = 0;
        while (j < nums.Length) {
            if (nums[j] == 0) {
                k--;
            }
            while (k < 0) {
                if (nums[i] == 0) {
                    k++;
                }
                i++;
            }
            maxLength = Math.Max(maxLength, j - i + 1);
            j++;
        }
        return maxLength;
    }
}
