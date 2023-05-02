namespace Container_with_most_water
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[] {1, 8, 6, 2, 5, 4, 8, 3, 7};
            Console.WriteLine(MaxArea(arr));
        }
        static int MaxArea(int[] height)
        {


            int leftIndex = 0;
            int rightIndex = height.Length - 1;
            int biggestSum = 0;

            while (leftIndex < rightIndex)
            {
                int leftValue = height[leftIndex];
                int rightValue = height[rightIndex];
                int cubeHeight = Math.Min(leftValue, rightValue);
                int cubeWidth = rightIndex - leftIndex;
                int cubeArea = cubeWidth * cubeHeight;
                if (cubeArea > biggestSum)
                {
                    biggestSum = cubeArea;
                }

                if (leftValue < rightValue)
                {
                    leftIndex++;
                }
                else if (leftValue > rightValue)
                {
                    rightIndex--;
                }
                else
                {
                    leftIndex++;
                    rightIndex--;
                }
            }


            return biggestSum;
        }
    }



}


