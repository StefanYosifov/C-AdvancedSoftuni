namespace Longest_Substring_Without_Repeating_Characters
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LengthOfLongestSubstring("pwwkew"));
        }

        public static int LengthOfLongestSubstring(string s)
        {
            int longestSequence = 0;
            int currentLenghtOfSequence=0;
            string currentSequence = "";
            for(int i = 0; i < s.Length; i++)
            {
                if (currentSequence.Contains(s[i]))
                {
                    currentSequence = "";
                    currentLenghtOfSequence = 0;
                    longestSequence = Math.Max(longestSequence, currentLenghtOfSequence);
                }
                else
                {
                    currentSequence += s[i];
                    currentLenghtOfSequence++;
                    longestSequence = Math.Max(longestSequence, currentLenghtOfSequence);
                }
            }
            return longestSequence;
        }
    }
}

