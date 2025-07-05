using PrimeCalcNS;

namespace PrimeCalcTestNS
{
    [TestClass]
    public class PrimeCalcTest
    {
        static PrimeCalc primeCalc;

        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            primeCalc = new PrimeCalc();
        }

        [TestMethod]
        [DataRow(-1, false)]
        [DataRow(0, false)]
        [DataRow(1, true)]
        [DataRow(2, true)]
        [DataRow(3, true)]
        [DataRow(4, false)]
        [DataRow(0.1, false)]
        [DataRow(3.3, false)]
        public void IsPrimeTest(double num, bool expRes)
        {
            bool res = primeCalc.IsPrime(num);
            Assert.AreEqual(res, expRes);
        }
    }
}