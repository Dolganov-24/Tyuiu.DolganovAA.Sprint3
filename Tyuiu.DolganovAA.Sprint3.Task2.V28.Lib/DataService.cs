using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.DolganovAA.Sprint3.Task2.V28.Lib
{
    public class DataService
    {
        public double CalcResult()
        {
            double product = 1;
            int k = 1;

            do
            {
                double element = (Math.Pow(2, k) / (k + 1)) * Math.Cos(1.8);
                product *= element;
                k++;
            } while (k <= 9);

            return product;
        }
    }
}