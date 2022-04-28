using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.IO;
using System;
namespace TestProjectApp
{
    [TestClass]
    public class UnitTest1
    {
        private const string Expected = "Hello World for VDR";
        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                ConsoleAppTest.Program.Main();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }
    }
}
