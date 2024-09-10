public class Solution {
    public string ReverseVowels(string s) {
        HashSet<char> vowels = new HashSet<char> {'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'};
        char[] chars = s.ToCharArray();
        int i = 0, j = chars.Length - 1;
        while (i < j) {
            if (!vowels.Contains(chars[i])) {
                i++;
            } else if (!vowels.Contains(chars[j])) {
                j--;
            } else {
                char temp = chars[i];
                chars[i] = chars[j];
                chars[j] = temp;
                i++;
                j--;
            }
        }
        return new string(chars);
    }
}
