using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digital_watch_wpf
{
    class Num
    {
        List<bool[]> nums = new List<bool[]>();
        public bool[] currentNum = new bool[7];

        public int CurrentNum
        {
            set
            {
                if (value == 0 || value == 1 || value == 2 || value == 3 || value == 4 || value == 5 || value == 6 || value == 7 || value == 8 || value == 9)
                {
                    currentNum = nums[value];
                }
            }
        }

        public Num()
        {
            nums.Add(new bool[] {true, false, true, true, true, true, true});       //0
            nums.Add(new bool[] {false, false, false, false, true, false, true});   //1
            nums.Add(new bool[] {true, true, true, false, true, true, false});     //2
            nums.Add(new bool[] {true, true, true, false, true, false, true});      //3
            nums.Add(new bool[] {false, true, false, true, true, false, true});    //4
            nums.Add(new bool[] {true, true, true, true, false, false, true});     //5
            nums.Add(new bool[] {true, true, true, true, false, true, true});       //6
            nums.Add(new bool[] {true, false, false, false, true, false, true});    //7
            nums.Add(new bool[] {true, true, true, true, true, true, true});        //8
            nums.Add(new bool[] { true, true, true, true, true, false, true});     //9
        }
    }
}
