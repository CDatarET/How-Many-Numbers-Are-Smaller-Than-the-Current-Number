public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
        int[] ret = new int[nums.Length];
        for(int i = 0; i < nums.Length; i++){
            int s = 0;
            for(int j = 0; j < nums.Length; j++){
                if(nums[i] > nums[j]){
                    s++;
                }
            }
            ret[i] = s;
        }

        return(ret);
    }
}
