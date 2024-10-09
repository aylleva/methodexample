using System.Runtime.InteropServices;

namespace methodtask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 6, 45, 3, 87, 1, 23,-87,  65, 100 };
            Console.WriteLine(GetMin(nums));
        }
        public static int GetMin(int[] nums)
        {
            int min = nums[0]; 
            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < min)
                {
                    min = nums[i];
                }
                
            }
            return min;
          
        }
    }
}