public class Solution 
{
    public int LengthOfLongestSubstring(string s) 
    {
        HashSet<char> set = new HashSet<char>();

        int left = 0;
        int maxLength = 0;
        int right = 0;

        foreach (char ch in s)
        {
            while (set.Contains(ch))
            {
                set.Remove(s[left]);
                left++;
            }

            set.Add(ch);

            maxLength = Math.Max(maxLength, right - left + 1);

            right++;
        }

        return maxLength;
    }
}