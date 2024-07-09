public class Solution {
    public int MinimumOperations(int[] nums) {
       int count = 0; 
        for (int i = 0; i < nums.Length; i++)
        {
            int num = nums[i];
            if(( num + 1) % 3 == 0 || (num - 1) % 3 == 0 || (num - 1) == 0) {
                count++;
            }
        }
        return count;
    }
}