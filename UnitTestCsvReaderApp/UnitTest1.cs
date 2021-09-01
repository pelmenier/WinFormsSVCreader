using Microsoft.VisualStudio.TestTools.UnitTesting;
using csvReaderApp;

namespace UnitTestCsvReaderApp
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodLoadFile()
        {
            var items = UserItem.LoadFile(@"D:\\userItems.csv");
            Assert.AreEqual(30, items.Count);
        }
    }
}
