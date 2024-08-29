using Microsoft.VisualStudio.TestTools.UnitTesting;
using KGSWebAGVSystemAPI.TaskOrder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGSWebAGVSystemAPI.TaskOrder.Tests
{
    [TestClass()]
    public class OrderAPITests
    {
        [ClassInitialize]
        public static void Init(TestContext cc)
        {
            Globals.KGSHotPort = 6600;
            Globals.KGSHotIP = "192.168.0.123";
            KGSWebAGVSystemAPI.User.Auth.LoginAndUpdateCookieStore("Paul", "1").GetAwaiter().GetResult();
        }

        [TestMethod()]
        public void AddTaskTest()
        {
            string response = OrderAPI.AddTask(new MissionRequestParams
            {
                AGVID = 1,
                Action = "Move",
                CarName = "AGV_001",
                FromStation = "1",
                ToStation = "2",
                CSTID = "CST_001",
                CSTType = 200
            }).GetAwaiter().GetResult();
        }

        [TestMethod()]
        public void CancelTaskTest()
        {
            OrderAPI.CancelTask($"*Local_123213213213").GetAwaiter().GetResult();
        }
    }
}