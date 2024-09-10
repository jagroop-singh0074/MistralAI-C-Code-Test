public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int[] answer = new int[n];
        Array.Fill(answer, 1);
        int leftProduct = 1;
        int rightProduct = 1;
        for (int i = 0; i < n; i++) {
            answer[i] *= leftProduct;
            leftProduct *= nums[i];
            answer[n - i - 1] *= rightProduct;
            rightProduct *= nums[n - i - 1];
        }
        return answer;
    }
}
