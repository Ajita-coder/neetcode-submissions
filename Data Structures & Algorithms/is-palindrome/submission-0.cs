public class Solution {
    public bool IsPalindrome(string s) {
        if(string.IsNullOrEmpty(s))
       return true;
       string cleaned = Regex.Replace(s, "[^a-zA-Z0-9]", "").ToLower();
        int left = 0, right = cleaned.Length - 1;
        while (left < right)
        {
            if (cleaned[left] != cleaned[right])
                return false;
            left++;
            right--;
        }
        return true;
    }
}
