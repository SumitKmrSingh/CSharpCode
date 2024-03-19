using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Practice
{
    class Demo
    {
        public int getArraySum(int[]arr)
        {
            int sum = 0;
            for(int i=0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            return sum;
        }
    }
}
