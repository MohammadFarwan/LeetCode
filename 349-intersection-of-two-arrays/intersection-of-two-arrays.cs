public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        List<int> intersections = new List<int>();

        foreach(var item1 in nums1)
        {
            foreach(var item2 in nums2)
            {
                if(item1 == item2)
                {
                    if(intersections.Contains(item1))
                    {
                        continue;
                    }else 
                    {
                        intersections.Add(item1);
                    }
                }
            }
            
        } 

        return intersections.ToArray();
    }
}