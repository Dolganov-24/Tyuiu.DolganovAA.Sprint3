using Tyuiu.DolganovAA.Sprint3.Task0.V2.Lib;

namespace Tyuiu.DolganovAA.Sprint3.Task0.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service = new DataService();
            Assert.AreEqual(0.021, service.GetMultiplySeries(1, 9));
        }
    }
}