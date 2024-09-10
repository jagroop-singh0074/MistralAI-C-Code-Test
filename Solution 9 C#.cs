public class Solution {
    public int Compress(char[] chars) {
        int i = 0;
        int j = 0;
        while (i < chars.Length) {
            int count = 1;
            while (i + count < chars.Length && chars[i + count] == chars[i]) {
                count++;
            }
            chars[j] = chars[i];
            j++;
            if (count > 1) {
                foreach (char digit in count.ToString()) {
                    chars[j] = digit;
                    j++;
                }
            }
            i += count;
        }
        return j;
    }
}
