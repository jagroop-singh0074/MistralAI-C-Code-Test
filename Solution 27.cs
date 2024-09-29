public class Solution {
    public int MaximizeSquareArea(int m, int n, int[] hFences, int[] vFences) {
        List<int> hList = new List<int>(hFences);
        List<int> vList = new List<int>(vFences);
        hList.Add(1);
        hList.Add(m);
        vList.Add(1);
        vList.Add(n);
        hList.Sort();
        vList.Sort();
        HashSet<int> hDiff = new HashSet<int>();
        HashSet<int> vDiff = new HashSet<int>();
        for (int i = 1; i < hList.Count; i++) {
            hDiff.Add(hList[i] - hList[i - 1]);
        }
        for (int i = 1; i < vList.Count; i++) {
            vDiff.Add(vList[i] - vList[i - 1]);
        }
        int maxLen = 0;
        foreach (int h in hDiff) {
            if (vDiff.Contains(h)) {
                maxLen = Math.Max(maxLen, h);
            }
        }
        return maxLen > 0 ? (int)Math.Pow(maxLen, 2) % (int)(1e9 + 7) : -1;
    }
}
