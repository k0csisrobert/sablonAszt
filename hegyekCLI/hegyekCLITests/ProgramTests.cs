using Microsoft.VisualStudio.TestTools.UnitTesting;
using hegyekCLI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hegyekCLI.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void tartalmazTest()
        {
            //Bükk; Fodor-hegy; Bükk-vidék => true
            bool elvart = true;
            bool bekert = Program.tartalmaz("Bükk", "Fodor-hegy", "Bükk-vidék");
            Assert.AreEqual(elvart, bekert);
        }
        [TestMethod()]
        public void tartalmazTest1()
        {
            //kő; Füstös-kő-bérc; Bükk-vidék; => true
            bool elvart = true;
            bool bekert = Program.tartalmaz("kő", "Füstös-kő-bérc", "Bükk-vidék");
            Assert.AreEqual(elvart, bekert);
        }

        [TestMethod()]
        public void tartalmazTest2()
        {
            //Bükk; Írott-kő; Kőszegi-hegység; => false
            bool elvart = false;
            bool bekert = Program.tartalmaz("Bükk", "Írott-kő", "Kőszegi-hegység");
            Assert.AreEqual(elvart, bekert);
        }
    }
}