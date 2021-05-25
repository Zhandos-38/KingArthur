using Microsoft.VisualStudio.TestTools.UnitTesting;
using KingArthur;
using System;
namespace KingArthurTest
{
    [TestClass]
    public class KingArthurTest
    {
        [TestMethod]
        public void Testing()
        {
            //Arrange
            int testNumberOfKnights = 0;
            KnightApp app = new KnightApp(testNumberOfKnights);
            //Act
            try
            {
                int answer = app.FindBestKnight();
                Assert.Fail();
            }
            catch (IndexOutOfRangeException)
            {
            }
        }
    }
}
