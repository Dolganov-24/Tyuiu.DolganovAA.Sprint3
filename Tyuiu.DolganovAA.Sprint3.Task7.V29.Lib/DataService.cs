using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.DolganovAA.Sprint3.Task7.V29.Lib
{
    public class DataService : ISprint3Task7V29
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] res;
            int len = ((stopValue - startValue) + 1);
            res = new double[len];
            int count = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                if ((Math.Cos(i) - 2.0 * i) != 0)
                {
                    res[count] = Math.Round(((2 * i - 3) / (Math.Cos(i) - 2 * i) + 5 * i - 6), 2);
                    count++;
                }
                else
                {
                    res[count] = 0.00;
                    count++;
                }
            }
            return res;
        }
    }
}