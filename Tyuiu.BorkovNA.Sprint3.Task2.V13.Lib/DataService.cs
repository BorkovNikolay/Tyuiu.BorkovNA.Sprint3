﻿using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BorkovNA.Sprint3.Task2.V13.Lib
{
    public class DataService : ISprint3Task2V13
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sum = 0;
            while (startValue < stopValue)
            {
                sum += (Math.Pow(value, startValue)+(2/(startValue+1)))*Math.Sin(value);
                startValue++;
            }
            return Math.Round(sum, 3);
        }
    }
}