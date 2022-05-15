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
        public static void marge(int [] arr, int left, int right, int mid)
        {
            //int mid = (left + right) / 2;

            //length of left array and right array
            int leftarraylen = mid - left+1;
            int rightarraylen = right - mid;

            int[] leftarray = new int[leftarraylen];
            int[] rightarray = new int[rightarraylen];
            int i, j;

            //coping into two arrays from the main array
            for (i = 0; i < leftarraylen; i++)
                leftarray[i] = arr[left+i];
            for(j=0;j<rightarraylen;j++)
                rightarray[j]= arr[mid+1+j];

            //initialize the index of first and second array 
            i = 0;
            j = 0;

            //initialize the marged array index

            int k = left;
            while(i< leftarraylen && j<rightarraylen)
            {
                if (leftarray[i] <= rightarray[j])
                    arr[k++] = leftarray[i++];
                else
                    arr[k++] = rightarray[j++];
                //k++;
            }

            // copy remaining elements of left array if any

            while(i< leftarraylen)
            {
                arr[k++] = leftarray[i++];
            }

            while(j<rightarraylen)
                arr[k++] = rightarray[j++];

        }

        static void sortArray(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;

                sortArray(arr, left, mid);
                sortArray(arr, mid + 1, right);

                marge(arr, left, right, mid);
            }
        }
            public static void print(int[] arr)
            {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
                
     

        public static void Main()
        {
            ulong num = 99;
            var arr = new int[16];
            var rand = new Random();
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rand.Next(10,1001);
            foreach(var item in arr)
                Console.Write("array->"+item);
             
            int gap = 4;
            string msg = "there is a boy";
            // Console.WriteLine(subSetofArray(arr));
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();

            // Console.WriteLine(SortArray(arr,0,arr.Length-1));
            //var ans = SortArray(arr, 0, arr.Length - 1);
            //Array.ForEach(SortArray(arr, 0, arr.Length - 1), Console.WriteLine);
            sortArray(arr,0,arr.Length-1);
            print(arr);
            //foreach(var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
        }
    }
}





