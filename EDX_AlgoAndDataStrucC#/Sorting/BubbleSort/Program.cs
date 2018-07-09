using System;
using System.Linq;
namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 5,10,3,2,4 };
            var swap = false;
            var count = nums.Length-1;
            do
            {
                swap = false;
                for(int i =0; i < count; i++ )
                {
                    if(nums[i]>nums[i+1])
                    {
                        var temp = nums[i];
                        nums[i] = nums[i+1];
                        nums[i+1] = temp;
                        swap = true;
                    }
                } 
                count--;
            }while(swap == true);

            nums.ToList().ForEach(x => {Console.WriteLine(x);});
            foreach(var num in nums){Console.WriteLine(num);}
        }
    }
}
