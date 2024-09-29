public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char, int> romanDict = new Dictionary<char, int> {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
        int result = 0;
        int prevVal = 0;
        foreach (char c in s) {
            int currVal = romanDict[c];
            if (currVal > prevVal) {
                result += currVal - 2 * prevVal;
            } else {
                result += currVal;
            }
            prevVal = currVal;
        }
        return result;
    }
}
