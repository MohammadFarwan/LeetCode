public class Solution {
    public int NumberOfEmployeesWhoMetTarget(int[] hours, int target) 
    {
        int br=0;
        foreach(int hour in hours)
        {
            if(hour>=target) br++;
        }
        return br;
    }
}