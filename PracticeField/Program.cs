using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PracticeField
{
    
    public class CodeForces
    {

      public static List<List<int>> subSetofArray(int[] arr)
        {
            List<List<int>> res = new List<List<int>>();//power set
            generateSubSet(0,arr,new List<int>(),res);
            return res;

        }

       public static void generateSubSet(int index, int[] arr, List<int> curr, List<List<int>> res)
        {
            res.Add(new List<int>(curr));
            for(int i=index;i<arr.Length;i++)
            {
                curr.Add(arr[i]);
                generateSubSet(i + 1,arr,curr,res);
                curr.Remove(curr.Count-1);
            }
        }

        public static void Main()
        {
            int[] arr = {1, 2, 3};
            int gap = 4;
            string msg = "there is a boy";
           // Console.WriteLine(subSetofArray(arr));
            foreach(var obj in subSetofArray(arr).SelectMany(l=>l.Select(o=>o)))
            {
                Console.WriteLine("["+obj+"]");
            }
        }
    }
}



//https://www.geeksforgeeks.org/browserstack-placement-paper/?ref=lbp

