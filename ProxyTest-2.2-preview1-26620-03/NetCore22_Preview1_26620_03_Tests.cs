using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProxyTest;
using System.Threading.Tasks;

namespace ProxyTest22_Preview1_26620_03
{
    [TestClass]
    public class NetCore22_Preview1_26620_03_Tests
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
