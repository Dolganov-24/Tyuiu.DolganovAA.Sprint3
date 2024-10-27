using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.DolganovAA.Sprint3.Task0.V2.Lib
{
    public class DataService : ISprint3Task0V2
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double sinValue = Math.Sin(1);
            double sinPowerNeg7 = Math.Pow(sinValue, -7);

            double result = 1.0;

            for (int i = startValue; i <= stopValue; i++)
            {
                double term = Math.Pow(i / sinPowerNeg7, -2);
                result *= term;
            }

            return Math.Round(result, 3);

        }
    }
}