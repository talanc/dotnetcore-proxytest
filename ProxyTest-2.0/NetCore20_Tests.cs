using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProxyTest;
using System.Threading.Tasks;

namespace ProxyTest20
{
    [TestClass]
    public class NetCore20_Tests
    {
        [TestMethod]
        public async Task NetCore20_Http()
        {
            await Class1.Http();
        }

        [TestMethod]
        public async Task NetCore20_Https()
        {
            await Class1.Https();
        }
    }
}
