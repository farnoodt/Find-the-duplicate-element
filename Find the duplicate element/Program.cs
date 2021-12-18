using System;

namespace Find_the_duplicate_element
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[]{ 1, 2, 3, 4, 2 };
            Console.WriteLine(findDuplicate(nums));
        }

        public static int findDuplicate(int[] nums)
        {
            int duplicate = -1;

            // do for each array element
            foreach (int i in  nums)
            {
                // get the value of the current element
                int val = (i < 0) ? -i : i;

                // make element at index `val` negative if it is positive
                if (nums[val] >= 0)
                {
                    nums[val] = -nums[val];
                }
                else
                {
                    // if the element is already negative, it is repeated
                    duplicate = val;
                    break;
                }
            }

            // restore the original array before returning
            for (int i = 0; i < nums.Length; i++)
            {
                // make negative elements positive
                if (nums[i] < 0)
                {
                    nums[i] = -nums[i];
                }
            }

            // return duplicate element
            return duplicate;
        }
    }
}
