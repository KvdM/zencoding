using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenCoding.Test.Css
{
    [TestClass]
    public class VisualFormatting
    {
        private ZenCoding.Parser _parser;

        [TestInitialize]
        public void Initialize()
        {
            _parser = new ZenCoding.Parser();
        }

        [TestMethod]
        public void Pos()
        {
            string result = _parser.Parse("pos", ZenType.CSS);
            string expected = "position:relative;";

            Assert.AreEqual(expected, result);
        }
    }
}