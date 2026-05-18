using Microsoft.VisualStudio.TestTools.UnitTesting;
using GLS_CLI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLS_CLI.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void NapiFogyasztásTest1()
        {
            Assert.AreEqual(Program.NapiFogyasztás(10,100),10);
        }

        [TestMethod()]
        public void NapiFogyasztásTest2()
        {
            Assert.AreEqual(Program.NapiFogyasztás(16, 200), 8);
        }

        [TestMethod()]
        public void NapiFogyasztásTest3()
        {
            Assert.AreEqual(Program.NapiFogyasztás(0, 0), 0);
        }
    }
}