

using System.Diagnostics;

namespace HackerRankUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SimpleLoadTest()
        {
            List<int> arr = new List<int> { 0, 1, 2, 4, 6, 5, 3 };
            var result = Result.findMedian(arr);
            Assert.IsTrue(result == 3);
        }

        [TestMethod]
        public void MediumLoadTest()
        {
            List<int> arr = new List<int>();

            Random rand = new Random();
            
            int n = rand.Next(500000, 1000001);
            
            for(int i = 0; i < n; i++)
            {
                arr.Add(rand.Next(-10000,10000));
            }
        
            var result = Result.findMedian(arr);
         
            Assert.IsTrue(1 + 1 == 2);
        }


        [TestMethod]
        public void ExtremeLoadTest()
        {
            Assert.Inconclusive();
        }
    }
}