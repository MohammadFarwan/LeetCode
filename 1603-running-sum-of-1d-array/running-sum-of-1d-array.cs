public class Solution {
    public int[] RunningSum(int[] nums) {
        int[] runningSum = new int[nums.Length];
        int numToAdd = 0;
        for (int i = 0; i < nums.Length; i++) {
            runningSum[i] = numToAdd + nums[i];
            numToAdd = runningSum[i];
        }
        return runningSum;
    }
}