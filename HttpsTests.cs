using Microsoft.VisualStudio.TestTools.UnitTesting;
using KGSWebAGVSystemAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGSWebAGVSystemAPI.Tests
{
    [TestClass()]
    public class HttpsTests
    {
        [TestMethod()]
        public void GETTest()
        {
            string responseString = Https.GET("/").GetAwaiter().GetResult();
            Console.WriteLine(responseString);
            Assert.IsTrue(responseString != null && responseString != "");
        }
    }
}