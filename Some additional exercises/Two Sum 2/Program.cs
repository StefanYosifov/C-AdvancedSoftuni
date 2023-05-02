namespace Two_Sum_2
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] result=(TwoSum(new int[]{ 2, 3, 4 },6));
            Console.WriteLine(String.Join(",",result));
        }

        public static int[] TwoSum(int[] numbers, int target)
        {
            int left = 0;
            int right = numbers.Length-1;
            List<List<int>> result = new List<List<int>>();
            while (left <= right)
            {
                if (numbers[left] + numbers[right] == target)
                {
                    break;
                }
                else if (numbers[left] + numbers[right] < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
                Console.WriteLine(left);
                Console.WriteLine(right);
            }
            return new int[] { left + 1, right + 1 };
        }
    }
}
