using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> nums = new List<int>();
            CustomList<int> nums = new CustomList<int>();
            nums.Add(5);
            nums.Add(7);
            //nums.Remove(5);
            Console.WriteLine(nums[0]);
        }
    }
}
