﻿using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BorkovNA.Sprint3.Task2.V13.Lib
{
    public class DataService : ISprint3Task2V13
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {



            double sum = 0;
            do
            {
                sum += (Math.Pow(value, startValue) + (2.0 / (startValue + 1.0))) * Math.Sin(value);
                startValue++;
            } while (startValue <= stopValue);
            return Math.Round(sum, 3);
        }
    }
}
