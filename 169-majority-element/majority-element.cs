public class Solution {
    public int MajorityElement(int[] nums) {
        var occurences = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int totalOccurance = 1;
            if (occurences.Contains(nums[i]))
            {
                continue;
            }

            for (int j = i+1; j < nums.Length; j++)
            {
                if (nums[i] == nums[j])
                {
                    totalOccurance++;
                }

                if (totalOccurance > nums.Length / 2)
                {
                    return nums[i];
                }
            }

            occurences.Add(nums[i]);
        }

        return nums.First();
    }
}