public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        List<int> list_x = new List<int>();
        List<int> list_y = new List<int>();
        List<int> list = new List<int>();
        for(int i = 0; i < n; i++)
        {
            list_x.Add(nums[i]);
        }
        for(int i = n; i < n * 2; i++)
        {
            list_y.Add(nums[i]);
        }
        for(int i = 0; i < n; i++)
        {
            list.Add(list_x[i]);
            list.Add(list_y[i]);
        }
        return list.ToArray();
            
    }   
}