using tyuiu.cources.programming.interfaces.Sprint3;


namespace Tyuiu.BorkovNA.Sprint3.Task7.V11.Lib
{
    public class DataService : ISprint3Task7V11
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
                double[] res = new double[stopValue - startValue + 1];
                int i = 0;
                while (i < res.Length)
                {
                    if (startValue + i == 1) 
                { 
                    res[i] = 0; 
                    i++; 
                    continue; 
                }
                    res[i] = F(startValue + i);
                    i++;
                }
                return res;
            }
            public double F(int x)
            {
                return Math.Round((Math.Cos(x) + (Math.Sin(x)) / (2 - 2*x))-4*x, 2);
            }

        }
    }

