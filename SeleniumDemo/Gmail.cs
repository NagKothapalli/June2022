using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumDemo
{
    [TestClass]
    public class Gmail
    {
        //******************Test Suites*******************
        [TestMethod]    
        public void SmokeSuite()
        {
            ComposeAndSendAnEmail();
            ReplyToAnEmail();
        }
        [TestMethod]
        public void RegressionSuite()
        {
            ComposeAndSendAnEmail();
            ReplyToAnEmail();
            ForwardAnEmail();
            DeleteAnEmail();
        }
        //**********************Test Cases**************************************
        [TestInitialize]
        public void Intilization()
        {
            LaunchApplication();
            LoginToApplication();
        }
        [TestCleanup]
        public void CleanUp()
        {
            LogoutFromApplication();
            CloseApplication();
        }

        [TestMethod]  
        public void ComposeAndSendAnEmail()
        { 
            //laucnh , login , compose , send , logout , close
            Console.WriteLine("Test Case : ComposeAndSendAnEmail");
            //LaunchApplication();
            //LoginToApplication();
            Compose();
            Send();
            //LogoutFromApplication();
            //CloseApplication();
        }
        [TestMethod]
        public void ReplyToAnEmail()
        {
            //laucnh , login , open , reply , logout , close
            Console.WriteLine("Test Case : ReplyToAnEmail");
            //LaunchApplication();
            //LoginToApplication();
            Open();
            Reply();
            //LogoutFromApplication();
            //CloseApplication();
        }
        [TestMethod]
        public void ForwardAnEmail()
        {
            //laucnh , login , open , forward , logout , close
            Console.WriteLine("Test Case : ForwardAnEmail");
            //LaunchApplication();
            //LoginToApplication();
            Open();
            Forward();
            //LogoutFromApplication();
            //CloseApplication();
        }
        [TestMethod]
        public void DeleteAnEmail()
        {
            //laucnh , login , open , delete , logout , close
            Console.WriteLine("Test Case : DeleteAnEmail");
            //LaunchApplication();
            //LoginToApplication();
            Open();
            Delete();
            //LogoutFromApplication();
            //CloseApplication();
        }
        //*********************Reusable Components*********************************
        public void LaunchApplication()
        {
            Console.WriteLine("Launch Application");
        }
        public void LoginToApplication()
        {
            Console.WriteLine("Login To Application");
        }
        public void LogoutFromApplication()
        {
            Console.WriteLine("Logout From Application");
        }
        public void CloseApplication()
        {
            Console.WriteLine("Close Application");
        }
        public void Compose()
        {
            Console.WriteLine("Compose Mail");
        }
        public void Send()
        {
            Console.WriteLine("Send Mail");
        }
        public void Open()
        {
            Console.WriteLine("Open Mail");
        }
        public void Reply()
        {
            Console.WriteLine("Reply Mail");
        }
        public void Forward()
        {
            Console.WriteLine("Forward Mail");
        }
        public void Delete()
        {
            Console.WriteLine("Delete Mail");
        }
    }
}
