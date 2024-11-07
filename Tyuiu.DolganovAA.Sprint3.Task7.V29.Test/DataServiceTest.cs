using Tyuiu.DolganovAA.Sprint3.Task7.V29.Lib;
namespace Tyuiu.DolganovAA.Sprint3.Task7.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
                DataService ds = new DataService();
                double[] res;
                res = new double[11];

                res[0] = -32.26;
                res[1] = -27.50;
                res[2] = -22.80;
                res[3] = -17.95;
                res[4] = -12.97;
                res[5] = -9.00;
                res[6] = -0.31;
                res[7] = 3.77;
                res[8] = 8.57;
                res[9] = 13.42;
                res[10] = 18.28;

                CollectionAssert.AreEqual(ds.GetMassFunction(-5, 5), res);
        }
    }
}