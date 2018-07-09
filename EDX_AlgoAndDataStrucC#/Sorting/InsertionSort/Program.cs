using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 7,8,4,6,2,1 };

            for(int i = 1; i<arr.Length; i++)
            {
                var currentValue = arr[i];
                int j = i;
                while(j>0 && currentValue < arr[j-1])
                {
                    arr[j] = arr[j-1];
                    j--;
                }
                arr[j] = currentValue;
            }

            foreach(var o in arr){Console.WriteLine(o);}
        }
    }
}
