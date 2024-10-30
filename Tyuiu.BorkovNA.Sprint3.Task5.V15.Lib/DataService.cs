using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BorkovNA.Sprint3.Task5.V15.Lib
{
    public class DataService : ISprint3Task5V15
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double esum = 0, sum = 0;
            int i = startValue1, k = startValue2;
            while (i <= stopValue1)
            {
                while (k <= stopValue2)
                {
                    sum += Math.Sin(x) + k * k / 2.0;
                    k++;
                }
                esum += sum; i++;
                sum = 0;
                k = 1;
            }
            return esum;
        }
    }
}
