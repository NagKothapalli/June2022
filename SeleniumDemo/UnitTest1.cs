using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SeleniumDemo
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine("Welcome to Selenium");  // System.out.println();  in java
        }

        [TestInitialize]   // @Before  - Junit
        public void LaunchApplication()
        {
            Console.WriteLine("Launch Application");
        }
        [TestMethod]   // @Test   - Junit
        public void LoginToApplication()
        {
            Console.WriteLine("Login To Application");
        }
        [TestCleanup]   //@After - Junit
        public void LogoutFromApplication()
        {
            Console.WriteLine("Logout From Application");
        }



    }
}
