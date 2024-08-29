using Microsoft.VisualStudio.TestTools.UnitTesting;
using KGSWebAGVSystemAPI.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGSWebAGVSystemAPI.User.Tests
{
    [TestClass()]
    public class AuthTests
    {
        [ClassInitialize]
        public static void Init(TestContext cc)
        {
            Globals.KGSHotPort = 6600;
            Globals.KGSHotIP = "192.168.0.123";
        }
        [TestMethod()]
        public void GetwebsiteSIDTest()
        {
            string result = Auth.GetwebsiteSID(CancellationToken.None).GetAwaiter().GetResult();
            Assert.IsTrue(result != null && result != "");
        }

        [TestMethod()]
        public void LoginTest()
        {
            Auth.LoginAndUpdateCookieStore("Paul", "1").GetAwaiter().GetResult();
        }
    }
}