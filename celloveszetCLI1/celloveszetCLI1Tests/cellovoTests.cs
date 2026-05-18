using Microsoft.VisualStudio.TestTools.UnitTesting;
using celloveszetCLI1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace celloveszetCLI1.Tests
{
    [TestClass()]
    public class cellovoTests
    {
        [TestMethod()]
        public void LegnagyobbTest()
        {
            cellovo test1 = new cellovo("Andi; 22; 29; 12; 23");
            //22; 29; 12; 23 => 29
            int elvart = 29;
            int eredmenyek = test1.Legnagyobb();
            Assert.AreEqual(elvart, eredmenyek);
        }

        [TestMethod()]
        public void LegnagyobbTest1()
        {
            cellovo test1 = new cellovo("Andi; 16; 45; 87; 33");
            //16; 45; 87; 33; => 87
            int elvart = 87;
            int eredmenyek = test1.Legnagyobb();
            Assert.AreEqual(elvart, eredmenyek);
        }
        [TestMethod()]
        public void LegnagyobbTest2()
        {
            cellovo test1 = new cellovo("Andi; 96; 49; 67; 45");
            //96; 49;67; 45 => 96
            int elvart = 96;
            int eredmenyek = test1.Legnagyobb();
            Assert.AreEqual(elvart, eredmenyek);
        }
        [TestMethod()]
        public void LegnagyobbTest3()
        {
            cellovo test1 = new cellovo("Andi; 44; 3; 12; 77");
            //44; 3;12; 77 => 77
            int elvart = 77;
            int eredmenyek = test1.Legnagyobb();
            Assert.AreEqual(elvart, eredmenyek);
        }
    }
}