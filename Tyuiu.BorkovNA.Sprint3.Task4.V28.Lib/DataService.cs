using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BorkovNA.Sprint3.Task4.V28.Lib
{
    public class DataService : ISprint3Task4V28
    {
        public double Calculate(int startValue, int stopValue)
        {
            int x;
            double sp = 0;
            int i = 0;
            for (x = startValue; x <= stopValue; x++)
            {

              if (x == 0)
                { 
                continue;
                }

                sp += (Math.Cos(x)+Math.Sin(x))/x;
                i++;
            }
            return Math.Round(sp, 3);

        }
    }
}
