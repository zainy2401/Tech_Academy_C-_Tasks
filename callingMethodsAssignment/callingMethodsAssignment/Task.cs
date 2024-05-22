using System;
using System.Collections.Generic;
using System.Text;

namespace callingMethodsAssignment
{
    class Task
    {
        public int Add(int input)
        {
            int result = input + 2;
            return result;
        }

        public int Subtract(int input)
        {
            int result = input - 2;
            return result;
        }

        public int Multiply(int input)
        {
            int result = input * 2;
            return result;
        }
    }
}
