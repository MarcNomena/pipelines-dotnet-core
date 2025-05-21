using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace pipelines_dotnet_core
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int result = 2 + 3;
            Assert.AreEqual(5, result);
        }
    }
}
