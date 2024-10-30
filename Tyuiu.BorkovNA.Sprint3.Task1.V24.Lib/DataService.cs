﻿using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BorkovNA.Sprint3.Task1.V24.Lib
{
    public class DataService : ISprint3Task1V24
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double sum = 0;
            while (startValue < stopValue)
            {
                sum += Math.Pow(2 / ( 6 + Math.Pow(value, startValue)), startValue);
                stopValue++;
            }
            return Math.Round(sum, 3);
        }
    }
}
