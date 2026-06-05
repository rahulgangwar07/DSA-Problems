using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Array
{
    internal class LongestSubstringWithoutRepeatingCharacters
    {

        //string str = "abcabcdbb";
        //int max = LongestSubstringWithoutRepeatingCharacters.RepeatingCharacters2(str);
        //Console.Write("Longest Substring Without Repeating Characters:  "+max);


        public static int RepeatingCharacters2(string strings)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();

            int left = 0;
            int max = 0;

            for (int right = 0; right < strings.Length; right++)
            {
                // Duplicate inside current window
                if (dic.ContainsKey(strings[right]) && dic[strings[right]] >= left)
                {
                    left = dic[strings[right]] + 1;
                }

                // Store/update latest index
                dic[strings[right]] = right;

                // Current window size
                int len = right - left + 1;

                max = Math.Max(max, len);
            }

            return max;
        }
        public static int RepeatingCharacters1(string strings)
        {
            int left = 0;
            int max = 0;
            HashSet<char> set = new HashSet<char>();

            for (int right = 0; right < strings.Length; right++)
            {
                while (set.Contains(strings[right]))
                {
                    set.Remove(strings[left]);
                    left++;
                }
                set.Add(strings[right]);

                int length = right - left + 1;
                
                max = Math.Max(max, length);

            }

            return max;
        }
        public static int RepeatingCharacters(string strings)
        {
            int max = 0;
            string newStr = "";
            for (int i = 0; i < strings.Length; i++)
            {
                string s = "";
                int count = 0;
                for (int j = i; j < strings.Length; j++)
                {

                    if (s.Contains(strings[j]))
                    {
                        break;
                    }
                    else
                    {
                        s += strings[j];
                        count++;
                    }
                    max = Math.Max(max, count);
                }

            }

            return max;
        }
    }
}

