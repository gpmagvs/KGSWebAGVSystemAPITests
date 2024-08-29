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
    public class KGSSettingsHelperTests
    {
        [TestMethod()]
        public void LogicContentTest()
        {
            var iniContext = KGSSettingsHelper.LogicContent();
            Console.WriteLine(iniContext);

        }

        [TestMethod()]
        public void GetCurrentMapUseFilePathTest()
        {
            string mapPath = KGSSettingsHelper.GetCurrentMapUseFilePath();
            Assert.AreEqual($"", mapPath);
        }
    }
}