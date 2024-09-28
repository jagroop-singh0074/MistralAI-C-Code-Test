public class Solution {
    private int n;
    private int[] tree;

    public IList<bool> GetResults(IList<IList<int>> queries) {
        IList<bool> results = new List<bool>();
        n = 50000;
        tree = new int[2 * n];

        foreach (var q in queries) {
            if (q[0] == 1) {
                Update(q[1], q[1]);
            } else {
                int res = Query(0, q[1] + 1);
                results.Add(res >= q[2]);
            }
        }

        return results;
    }

    private void Update(int p, int value) {
        p += n;
        tree[p] = value;
        while (p > 1) {
            tree[p >> 1] = Math.Max(tree[p], tree[p ^ 1]);
            p >>= 1;
        }
    }

    private int Query(int l, int r) {
        l += n;
        r += n;
        int res = 0;
        while (l < r) {
            if ((l & 1) > 0) {
                res = Math.Max(res, tree[l]);
                l += 1;
            }
            if ((r & 1) > 0) {
                res = Math.Max(res, tree[r - 1]);
                r -= 1;
            }
            l >>= 1;
            r >>= 1;
        }
        return res;
    }
}
