using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace DSA__VSCode.Arrays
{
    public class MergeSortedArray
    {
        public int[] Merge(int[] arr1, int[] arr2)
        {
            int arr1Length = arr1.Length;
            int arr2Length = arr2.Length;

            int[] mergedArrays = new int[arr1Length+arr2Length];

            if(arr1Length < 1 && arr2Length < 1) return null;

            if(arr1Length==0) return arr2;
            if(arr2Length==0) return arr1;
            int i = 0,j = 0, k = 0; 
            while(i < arr1Length && j < arr2Length)
            {
                if(arr1[i] < arr2[j])
                    mergedArrays[k++] = arr1[i++];
                else
                    mergedArrays[k++] = arr2[j++];
            }

            while( i< arr1Length)
                mergedArrays[k++] = arr1[i++];
            while(j< arr2Length)
                mergedArrays[k++] = arr2[j++];

            return mergedArrays;
        }

/*        
MergeSortedArray merge = new MergeSortedArray();

int[] arr1 ={3,4,98,100,101};
int[] arr2 ={2,8,9,88,97,135};

int[] result = merge.Merge(arr1, arr2);
for (int i = 0; i < result.Length; i++)
{
    Console.Write(result[i] + ",");
}*/

    }
}