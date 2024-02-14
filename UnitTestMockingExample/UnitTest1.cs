using EmpLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace UnitTestMockingExample
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        [TestMethod]
        public void MockTestExp()
        {
            //problem
            //CheckEmpSecondDevs checkEmpSecondDevs = new CheckEmpSecondDevs();
            //ProcessEmp processEmp = new ProcessEmp();
            //Assert.AreEqual(true, processEmp.InsertEmp(checkEmpSecondDevs));

            //mocking
            Mock<CheckEmpSecondDevs> chk = new Mock<CheckEmpSecondDevs>();
            chk.Setup(x => x.CheckEmp()).Returns (true);

            ProcessEmp proc = new ProcessEmp();
            Assert.AreEqual (true,proc.InsertEmp(chk.Object));

        }
    }
}
