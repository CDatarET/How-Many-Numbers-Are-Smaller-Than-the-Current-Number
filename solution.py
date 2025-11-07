class Solution:
    def smallerNumbersThanCurrent(self, nums):
        ret = []
        for i in range(len(nums)):
            s = 0
            for j in range(len(nums)):
                if nums[i] > nums[j]:
                    s += 1
            ret.append(s)
        
        return ret
