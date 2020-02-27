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
            CustomList<int> nums2 = new CustomList<int>();
            nums2.Add(4);
            nums2.Add(2);
            nums.Add(5);
            nums.Add(7);
            CustomList<int> resultList = new CustomList<int>();
            resultList = nums + nums2;
            //nums.Remove(5);
            Console.WriteLine(resultList[2]);
        }
    }
}
