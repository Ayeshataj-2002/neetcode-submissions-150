public class Solution 
{
    public int CharacterReplacement(string s, int k) 
    {
        Dictionary<char, int> map = new Dictionary<char, int>();

        int left = 0;
        int maxFreq = 0;
        int maxLength = 0;

        for (int right = 0; right < s.Length; right++)
        {
            char ch = s[right];

            if (!map.ContainsKey(ch))
            {
                map[ch] = 0;
            }

            map[ch]++;

            maxFreq = Math.Max(maxFreq, map[ch]);

            while ((right - left + 1) - maxFreq > k)
            {
                map[s[left]]--;
                left++;
            }

            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}