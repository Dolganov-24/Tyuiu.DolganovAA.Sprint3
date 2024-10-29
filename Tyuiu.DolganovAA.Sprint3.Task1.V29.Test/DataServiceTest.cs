using Tyuiu.DolganovAA.Sprint3.Task1.V29.Lib;
namespace Tyuiu.MiliukovLO.Sprint3.Task1.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(13051.34, ds.GetMultiplySeries(0.25, 1, 11));
        }
    }
}