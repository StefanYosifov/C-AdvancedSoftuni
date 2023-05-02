namespace _33._Search_in_Rotated_Sorted_Array
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 4, 5, 6, 7, 0, 1, 2 };
            int[] arr2 = new int[] { 4, 5, 6, 7, 0, 1, 2 };
            int[] arr3 = new int[] { 4, 5, 6, 7, 8, 9, 10, 11, 12, 0, 1, 2 };

            Console.WriteLine(Search(arr,0));
            Console.WriteLine(Search(arr2,0));
            Console.WriteLine(Search(arr3,0));
        }

        static public int Search(int[] nums, int target)
        {
            int leftIndexPivot = 0;
            int rightIndexPivot=nums.Length-1;
            int findPivotIndex = Math.Abs(nums[rightIndexPivot] - nums.Length)-1;
            int targetLooking = 0;


            int leftIndex = 0;
            int rightIndex = nums.Length - 1;
            if (target > nums[rightIndexPivot])//Look left
            {
                rightIndex = findPivotIndex;
                while (targetLooking != target)
                {
                    targetLooking = (nums[leftIndex] + nums[rightIndex]) / 2;
                    if (targetLooking < target)
                    {
                        leftIndex = nums[targetLooking];
                    }
                    else if (targetLooking > target)
                    {
                        rightIndex = nums[targetLooking];
                    }
                }
            }
            else if (target < nums[rightIndex]) // Look right
            {
                leftIndex = findPivotIndex;
            }

            while (targetLooking != target)
            {
                
               
            }
            return 0;
        }
    }
}
