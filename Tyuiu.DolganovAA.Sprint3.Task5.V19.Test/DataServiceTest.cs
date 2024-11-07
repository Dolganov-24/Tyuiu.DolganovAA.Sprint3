using Tyuiu.DolganovAA.Sprint3.Task5.V19.Lib;
namespace Tyuiu.DolganovAA.Sprint3.Task5.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetSumSumSeries2()
        {
            DataService ds = new DataService();
            int x = 2;
            int startValue1 = 1, startValue2 = 1, stopValue1 = 3, stopValue2 = 6;
            double expected = 30598.002;

            double actual = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            Assert.AreEqual(expected, actual, 0.0001, $"{expected}, {actual}");
        }
    }
}