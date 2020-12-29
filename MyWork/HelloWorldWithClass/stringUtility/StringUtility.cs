using System;

namespace stringUtility
{
    public class StringLibrary
    {
        public bool StartsWithUpper(String str)
        {
            if (String.IsNullOrWhiteSpace(str))
                return false;

            Char ch = str[0];
            return Char.IsUpper(ch);
        }

        public bool IsStringPalindrome(string str)
        {
            string revs = "";
            for (int i = str.Length - 1; i >= 0; i--) //String Reverse
            {
                revs += str[i].ToString();
            }
            if (revs == str) // Checking whether string is palindrome or not
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}