using Hl7.Fhir.ElementModel.Types;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    //03 may 2025
    internal class counterGameProblem
    {
        public static void hallo(string[] args)
        {
            Console.WriteLine("Kaise hai aap"); 

        }
        class Calculator
        { 
        }


        public static string counterGame(long n)
        {
            int moves = 0;

            while (n > 1)
            {
                if ((n & (n - 1)) == 0)
                {
                    // n is a power of 2, divide by 2
                    n >>= 1;
                }
                else
                {
                    // subtract the largest power of 2 less than n
                    long highestPower = highestOneBit(n);
                    n -= highestPower;
                }

                moves++;
            }

            return (moves % 2 == 0) ? "Richard" : "Louise";
        }

        private static long highestOneBit(long n)
        {
            long power = 1;
            while(power<<1 <= n)
            {
                power <<= 1;
            }
            return power;
        }


        ///////////////////////
        //public static string counterGame(long n)
        //{ 
        //    int flag = 1;

        //    while (true)
        //    {
        //        if (n == 1)
        //        {
        //            if (flag % 2 != 0)
        //            {
        //                return "Richard";
        //            }
        //            else
        //            {
        //                return "Louise";
        //            }

        //        }

        //        n = findLastCounter(n);
        //        flag++;
        //    } 
        //}

        //private static long findLastCounter(long c)
        //{
        //    long val = 1;
        //    while (true)
        //    {
        //        val *= 2;
        //        if (val <= c && c/2<val)
        //        {
        //            break;
        //        }

        //    }
        //    if(val == c)
        //    {
        //        return val/2;
        //    }
        //    else
        //    {
        //        return c - val;
        //    } 
        //}

        ////////////////////////////////
        ///
        //public static string counterGame(long n)
        //{
        //    int flag = 1;

        //    while (true)
        //    {
        //        if (n == 1)
        //        {
        //            if (flag % 2 != 0)
        //            {
        //                return "Richard";
        //            }
        //            else
        //            {
        //                return "Louise";
        //            }

        //        }
        //        if (findSquare(n))
        //        {
        //            n /= 2;
        //        }
        //        else
        //        {
        //            n = n - subtratValue(n);
        //        }

        //        flag++;
        //    }
        //}

        //private static bool findSquare(long c)
        //{
        //    if ((c & (c - 1)) == 0)
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        //public static long subtratValue(long n)
        //{
        //    long val = 1;
        //    while (val * 2 < n)
        //    {
        //        val *= 2;
        //    }
        //    return val;
        //}




    }
}
