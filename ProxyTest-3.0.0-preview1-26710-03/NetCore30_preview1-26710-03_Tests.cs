using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProxyTest;
using System.Threading.Tasks;

namespace ProxyTest30_Preview1_26710_03
{
    [TestClass]
    public class NetCore30_Preview1_26710_03_Tests
    {
        [TestMethod]
        public async Task NetCore30_Http()
        {
            await Class1.Http();
        }

        [TestMethod]
        public async Task NetCore30_Https()
        {
            await Class1.Https();
        }
    }
}
