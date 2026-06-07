using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Array
{
    internal class MajorityElement
    {
        //int[] arr = { 7, 1, 5, 3, 6, 4 };
        ////int[] arr = { 1, 2, 1, 3, 1 };

        //int[] ans = MajorityElement.Majorities(arr);
        //if (ans[1] == 0)
        //{
        //    Console.WriteLine("No majority Elements Exists.");
        //}
        //else
        //{
        //    Console.WriteLine(ans[0] + " appears " + ans[1] + " times.");
        //}

        public static int[] Majorities(int[] arr)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (dic.ContainsKey(arr[i]))
                {
                    dic[arr[i]]++;
                }
                else
                {
                    dic[arr[i]] = 1;
                }
            }
            int maxValue = 0;
            int key = 0;
            foreach (var d in dic)
            {
                if (maxValue < d.Value)
                {
                    maxValue = d.Value;
                    key = d.Key;
                }
            }

            maxValue = maxValue > arr.Length / 2 ? maxValue : 0;

            return new int[] { key, maxValue };
        }
    }
    
}

