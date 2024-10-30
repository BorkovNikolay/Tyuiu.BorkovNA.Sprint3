using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BorkovNA.Sprint3.Task6.V19.Lib
{
    public class DataService : ISprint3Task6V19
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int count = 0;
            int x;
            for (x = startValue; x <= stopValue; x++)
            {
                for (int y = 1; y <= x; y++)
                {
                    if (x % y == 0)
                    {
                        if(y< 8)
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
    }
}
