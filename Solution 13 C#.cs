public class Solution {
    public int MaxVowels(string s, int k) {
        HashSet<char> vowels = new HashSet<char> {'a', 'e', 'i', 'o', 'u'};
        int maxCount = 0;
        int currCount = 0;
        for (int i = 0; i < s.Length; i++) {
            if (vowels.Contains(s[i])) {
                currCount++;
            }
            if (i >= k && vowels.Contains(s[i - k])) {
                currCount--;
            }
            maxCount = Math.Max(maxCount, currCount);
        }
        return maxCount;
    }
}
