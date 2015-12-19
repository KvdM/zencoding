using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenCoding.Test.Css
{
    [TestClass]
    public   class Tables
    {
        private ZenCoding.Parser _parser;

        [TestInitialize]
        public void Initialize()
        {
            _parser = new ZenCoding.Parser();
        }

        [TestMethod]
        public void Tbl()
        {
            string result = _parser.Parse("tbl", ZenType.CSS);
            string expected = "table-layout:";

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Tbla()
        {
            string result = _parser.Parse("tbl:a", ZenType.CSS);
            string expected = "table-layout:auto;";

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Tblf()
        {
            string result = _parser.Parse("tbl:f", ZenType.CSS);
            string expected = "table-layout:fixed;";

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Cps()
        {
            string result = _parser.Parse("cps", ZenType.CSS);
            string expected = "caption-side:";

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CpsT()
        {
            string result = _parser.Parse("cps:t", ZenType.CSS);
            string expected = "caption-side:top;";

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CpsB()
        {
            string result = _parser.Parse("cps:b", ZenType.CSS);
            string expected = "caption-side:bottom;";

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Ec()
        {
            string result = _parser.Parse("ec", ZenType.CSS);
            string expected = "empty-cells:";

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void EcS()
        {
            string result = _parser.Parse("ec:s", ZenType.CSS);
            string expected = "empty-cells:show;";

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void EcH()
        {
            string result = _parser.Parse("ec:h", ZenType.CSS);
            string expected = "empty-cells:hide;";

            Assert.AreEqual(expected, result);
        }
    }
}
