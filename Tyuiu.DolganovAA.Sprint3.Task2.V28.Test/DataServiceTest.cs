using Tyuiu.DolganovAA.Sprint3.Task2.V28.Lib;
namespace Tyuiu.DolganovAA.Sprint3.Task2.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalcResult()
        {
            DataService ds = new DataService();
            double res = ds.CalcResult(); 

            double expected = 1;
            for (int k = 1; k <= 9; k++)
            {
                expected *= (Math.Pow(2, k) / (k + 1)) * Math.Cos(1.8);
            }

            Assert.AreEqual(expected, res, 0.0001);
        }

        [TestMethod]
        public void TestCalcResultIsNotZero()
        {
            DataService ds = new DataService();
            double res = ds.CalcResult();

            Assert.IsTrue(res != 0, "Non");
        }
    }
}