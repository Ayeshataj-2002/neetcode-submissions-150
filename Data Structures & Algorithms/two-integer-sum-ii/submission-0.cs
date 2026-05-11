public class Solution {
    public int[] TwoSum(int[] numbers, int target) {

        int left = 0;
        int right = numbers.Length - 1;

        while (left < right)
        {
            int sum = numbers[left] + numbers[right];

            // If target found
            if (sum == target)
            {
                return new int[] { left + 1, right + 1 };
            }

            // If sum is smaller, move left pointer
            else if (sum < target)
            {
                left++;
            }

            // If sum is bigger, move right pointer
            else
            {
                right--;
            }
        }

        return new int[] { };
    }
}