﻿using System;

namespace Calculator
{
    public class Calculator
    {
        public int Add(int summandA, int summandB)
        {
            return summandA + summandB;//+1
        }

        public int Subtract(int minuend, int subtrahend)
        {
            return minuend - subtrahend;
        }

        public int Multiply(int multiplientA, int multiplientB)
        {
            return multiplientA * multiplientB;
        }

        public int Devide(int DividentA, int DividentB)
        {
            return DividentA / DividentB;
        }

    }
}
