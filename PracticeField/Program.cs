using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Text;

namespace PracticeField
{
    
    public class CodeForces
    {

        static int knapSack(int bagWeight, int[] itemWeight, int[] itemValue, int numberofItems)
        {
            int[] dp = new int[bagWeight];
            for (int i = 1; i < numberofItems + 1; i++)
            {
                for (int w = bagWeight; w >= 0; w--)
                {
                    if (itemWeight[i - 1] <= w)
                        dp[w] = Math.Max(dp[bagWeight], dp[w - itemWeight[i - 1]] + itemValue[i - 1]);
                }

            }


            return dp[bagWeight];
        }

        

        public static void Main()
        {
            int[] val = new int[] { 60, 100, 120 };
            int[] wt = new int[] { 10, 20, 30 };
            int W = 50;
            int n = val.Length;

            Console.Write(knapSack(W, wt, val, n));
        }
    }
}



//https://www.geeksforgeeks.org/browserstack-placement-paper/?ref=lbp

