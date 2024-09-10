public class Solution {
    public void MoveZeroes(int[] nums) {
        int i = 0;
        int j = 0;
        while (j < nums.Length) {
            if (nums[j] != 0) {
                int temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
                i++;
            }
            j++;
        }
        while (i < nums.Length) {
            nums[i] = 0;
            i++;
        }
    }
}
