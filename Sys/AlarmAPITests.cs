using Microsoft.VisualStudio.TestTools.UnitTesting;
using KGSWebAGVSystemAPI.Sys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGSWebAGVSystemAPI.Sys.Tests
{
    [TestClass()]
    public class AlarmAPITests
    {
        [ClassInitialize]
        public static void Init(TestContext cc)
        {
            Globals.KGSHotPort = 6600;
            Globals.KGSHotIP = "192.168.0.123";
            KGSWebAGVSystemAPI.User.Auth.LoginAndUpdateCookieStore("Paul", "1").GetAwaiter().GetResult();
        }
        [TestMethod()]
        public void ResetAlarmTest()
        {
            AlarmAPI.ResetAlarm().GetAwaiter().GetResult();
        }

        [TestMethod()]
        public void BuzzerOffTest()
        {
            AlarmAPI.BuzzerOff().GetAwaiter().GetResult();
        }
    }
}