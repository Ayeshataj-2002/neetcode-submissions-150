public class Solution 
{
    public int LongestConsecutive(int[] nums) 
    {
        // Store all numbers in HashSet
        HashSet<int> set = new HashSet<int>(nums);

        int longest = 0;

        foreach (int num in set)
        {
            // Check if it is the start of a sequence
            if (!set.Contains(num - 1))
            {
                int currentNum = num;
                int count = 1;

                // Count consecutive numbers
                while (set.Contains(currentNum + 1))
                {
                    currentNum++;
                    count++;
                }

                longest = Math.Max(longest, count);
            }
        }

        return longest;
    }
}