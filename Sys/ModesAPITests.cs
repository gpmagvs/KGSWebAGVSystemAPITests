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
    public class ModesAPITests
    {
        [ClassInitialize]
        public static void Init(TestContext cc)
        {
            Globals.KGSHotPort = 6600;
            Globals.KGSHotIP = "192.168.0.123";
        }
        [TestMethod()]
        public void OPModeSwitchToAutoTest()
        {
            ModesAPI.OPModeSwitch(OP_MODE.AUTO).GetAwaiter().GetResult();
        }
        [TestMethod()]
        public void OPModeSwitchOPTest()
        {
            ModesAPI.OPModeSwitch(OP_MODE.OP).GetAwaiter().GetResult();
        }
    }
}