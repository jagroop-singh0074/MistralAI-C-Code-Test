public class Solution {
    public int StrongPasswordChecker(string password) {
        int missingTypes = 3;
        if (password.Any(c => c >= 'a' && c <= 'z')) missingTypes--;
        if (password.Any(c => c >= 'A' && c <= 'Z')) missingTypes--;
        if (password.Any(c => char.IsDigit(c))) missingTypes--;

        int replace = 0;
        int one = 0;
        int two = 0;
        var p = Regex.Replace(password, @"(.)\1*", "$1");
        foreach (Match match in Regex.Matches(password, @"(.)\1*")) {
            var b = match.Value;
            if (b.Length < 3) continue;
            int l = b.Length;
            replace += l / 3;
            if (l % 3 == 0) one++;
            else if (l % 3 == 1) two++;
        }

        if (password.Length > 20) {
            int delete = password.Length - 20;
            if (delete <= replace) {
                replace -= delete;
                return delete + Math.Max(missingTypes, replace);
            } else {
                replace = Math.Max(0, replace - (delete - replace));
                return delete + Math.Max(missingTypes, replace);
            }
        } else if (password.Length < 6) {
            return Math.Max(missingTypes, 6 - password.Length);
        } else {
            return Math.Max(missingTypes, replace);
        }
    }
}
