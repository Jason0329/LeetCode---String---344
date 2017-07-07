using System;
using System.Text;

namespace LeetCode___String___344
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution ss = new Solution();
            Console.Write(ss.ReverseString("Hello World!"));
        }
    }

    public class Solution
    {
        public string ReverseString(string s)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = s.Length; i >= 1; i--)
            {
                sb.Append(s[i-1]);
            }
            return sb.ToString();

        }
    }
}