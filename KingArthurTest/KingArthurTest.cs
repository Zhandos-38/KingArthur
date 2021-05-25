using Microsoft.VisualStudio.TestTools.UnitTesting;
using KingArthur;

namespace KingArthurTest
{
    [TestClass]
    public class KingArthurTest
    {
        [TestMethod]
        public void Testing()
        {
            //Arrange
            int testNumberOfKnights = 20;
            int expected = 9;
            KnightApp app = new KnightApp(testNumberOfKnights); 
            //Act
            int answer = app.FindBestKnight();

            //Assert
            Assert.AreEqual(expected, answer);
        }
    }
}
