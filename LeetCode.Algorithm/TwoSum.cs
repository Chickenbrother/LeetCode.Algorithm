using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Algorithm
{
    public class TwoSumSolution
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] ret = new int[2];
            //nums = nums.OrderBy(it => it).ToArray();
            for (int i = 0; i < nums.Count() - 1; i++)
            {
                for (int j = i + 1; j < nums.Count(); j++)
                {

                    if ((target - nums[i]).Equals(nums[j]))
                    {
                        ret[0] = i;
                        ret[1] = j;
                        return ret;
                    }
                }
            }
            return ret;
        }
    }
}
