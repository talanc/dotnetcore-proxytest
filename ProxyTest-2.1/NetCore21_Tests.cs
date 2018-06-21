using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProxyTest;
using System.Threading.Tasks;

namespace ProxyTest21
{
    [TestClass]
    public class NetCore21_Tests
    {
        [TestMethod]
        public async Task NetCore21_Http()
        {
            await Class1.Http();
        }

        [TestMethod]
        public async Task NetCore21_Https()
        {
            await Class1.Https();
        }
    }
}
