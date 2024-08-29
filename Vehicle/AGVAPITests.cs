using Microsoft.VisualStudio.TestTools.UnitTesting;
using KGSWebAGVSystemAPI.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGSWebAGVSystemAPI.Vehicle.Tests
{
    [TestClass()]
    public class AGVAPITests
    {
        [ClassInitialize]
        public static void Init(TestContext cc)
        {
            Globals.KGSHotPort = 6600;
            Globals.KGSHotIP = "192.168.0.123";
            KGSWebAGVSystemAPI.User.Auth.LoginAndUpdateCookieStore("Paul", "1").GetAwaiter().GetResult();
        }
        [TestMethod()]
        public void ONLINETest()
        {
            Vehicle.AGVAPI.ONLINE("1").GetAwaiter().GetResult();
        }

        [TestMethod()]
        public void OFFLINETest()
        {
            Vehicle.AGVAPI.OFFLINE("1").GetAwaiter().GetResult();

        }
    }
}