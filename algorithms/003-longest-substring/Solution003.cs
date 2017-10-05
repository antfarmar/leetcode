using System;
using System.Collections.Generic;

namespace algorithms
{
    public class Solution003
    {
        public static void Main(string[] args)
        {
            string input = "abcabcbb";
            int answer = new Solution003().LengthOfLongestSubstring(input);
            Console.WriteLine(answer);
        }

        public int LengthOfLongestSubstring(String s)
        {
            int n = s.Length;
            int ans = 0;
            int[] index = new int[128]; // current index of character
            
            // Try to extend the range [i, j]
            for (int j = 0, i = 0; j < n; j++)
            {
                i = Math.Max(index[s[j]], i);
                ans = Math.Max(ans, j - i + 1);
                index[s[j]] = j + 1;
            }
            return ans;
        }
    }
}