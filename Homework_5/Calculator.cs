using System;

namespace Homework_5
{
    internal class Calculator
    {
        private int number;

        public Calculator() 
        {
        }

        public Calculator(int number) 
        {
            this.number = number;
        }

        public int Number
        {
            get { return number; }
            set
            {
                if (value < 2147483647 && value > -2147483648)
                {
                    number = value;
                }
                else
                {
                    throw new Exception("Number is out of range int");
                }
            }
        }

        public override string ToString() 
        {
            return String.Format($"Number = {number}");
        }
    }
}
