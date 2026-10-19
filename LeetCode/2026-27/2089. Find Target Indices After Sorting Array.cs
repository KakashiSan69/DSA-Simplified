/*Intuition

Sorting places all numbers smaller than target before it.
The count of smaller numbers gives the starting index of target.
The count of occurrences tells us how many consecutive indices to return.
Approach

Traverse the array once to count numbers smaller than target and occurrences of target.
Starting from startIndex, add count consecutive indices to the result.
Complexity

Time complexity: O(n)
Space complexity: O(count)
*/

public class Solution {
    public IList<int> TargetIndices(int[] nums, int target) {
        
        int startIndex = 0;
        int count = 0;

        for(int i=0; i<nums.Length; i++){
            if(nums[i] < target) startIndex++;
            if(nums[i] == target) count++;
        }

        IList<int> res = [];
        for(int i = 0; i < count; i++){
            res.Add(startIndex + i);
        }

        return res;
    }
}