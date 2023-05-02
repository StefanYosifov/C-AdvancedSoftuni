namespace Valid_palindrome
{
    using System;
    using System.Text;

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome("A man, a plan, a canal: Panama"));
        }

        public static bool IsPalindrome(string s)
        {
            StringBuilder lowerCaseWord=new StringBuilder();
            
          
            foreach(var currentChar in s){
                if (Char.IsLetterOrDigit(currentChar))
                {
                    lowerCaseWord.Append(currentChar.ToString().ToLower());
                }
            }
            
            for(int i = 0; i < lowerCaseWord.Length; i++)
            {
                if (lowerCaseWord[i] != lowerCaseWord[lowerCaseWord.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
