public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> count = new Dictionary<int, int>();

        foreach(int num in nums)
        {
            if(count.ContainsKey(num))
            count[num]++;
            else 
            count[num] = 1;
        }

        var result = count
        .OrderByDescending(x => x.Value)
        .Take(k)
        .Select(x => x.Key)
        .ToArray();

        return result;
    }
}
