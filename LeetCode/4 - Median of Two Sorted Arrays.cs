namespace LeetCode;

public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        var list = new List<int>(nums1);
        for(var i = 0; i < nums2.Length; i++)
        {
            var index = list.BinarySearch(nums2[i]);
            if (index < 0)
                index = ~index;

            list.Insert(index, nums2[i]);
        }

        if(list.Count % 2 == 0)
        {
            var index = list.Count / 2;
            return (list[index] + list[index - 1]) / 2.0;
        }
        
        return list[list.Count / 2];
    }
}