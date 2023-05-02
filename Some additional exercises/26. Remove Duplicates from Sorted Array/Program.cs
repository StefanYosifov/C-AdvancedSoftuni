namespace _26._Remove_Duplicates_from_Sorted_Array
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            Console.WriteLine(RemoveDuplicates(arr));
        }
        static public int RemoveDuplicates(int[] nums)
        {
            int counter = 1;

            for(int i = 0; i < nums.Length-1; i++)
            {
                if (nums[i] != nums[i + 1])
                {
                    nums[counter]=nums[i+1];
                    counter++;
                }
            }
            return counter;
        }
    }
}
