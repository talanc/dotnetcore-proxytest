using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProxyLib;
using System.Threading.Tasks;

namespace ProxyTest22
{
    [TestClass]
    public class NetCore22_Tests
    {
        [TestMethod]
        public async Task NetCore22_Http()
        {
            await Class1.Http();
        }

        [TestMethod]
        public async Task NetCore22_Https()
        {
            await Class1.Https();
        }
    }
}
