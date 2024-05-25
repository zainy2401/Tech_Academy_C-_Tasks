using System;
using System.Collections.Generic;
using System.Text;

namespace MainMethodAssignment
{
    class Operations
    {
        public int addition(int input)
        {
            int result = input + 5;
            return result;
        }
        public int addition(float input)
        {
            int result = (int)(input + 5);
            return result;
        }
        public int addition(string input)
        {
            int result = Convert.ToInt32(input) + 5;
            return result;
        }
    }
}
