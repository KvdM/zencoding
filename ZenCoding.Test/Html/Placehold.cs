﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ZenCoding.Test
{
    [TestClass]
    public class PlaceHold
    {
        private ZenCoding.Parser _parser;

        [TestInitialize]
        public void Initialize()
        {
            _parser = new ZenCoding.Parser();
        }

        [TestMethod]
        public void PlaceHold1()
        {
            string result = _parser.Parse("place", ZenType.HTML);
            string expected = "<img src=\"http://placehold.it/30x30/\" alt=\"\" />";

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void PlaceHold2()
        {
            string result = _parser.Parse("place-30-png", ZenType.HTML);
            string expected = "<img src=\"http://placehold.it/30x30/png/\" alt=\"\" />";

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void PlaceHold3()
        {
            string result = _parser.Parse("place-120x1879-jpeg-t=SomeRandomText", ZenType.HTML);
            string expected = "http://placehold.it/120x1879/jpeg/&text=SomeRandomText";

            StringAssert.Contains(result, expected);
        }

        [TestMethod]
        public void PlaceHold4()
        {
            string result = _parser.Parse("place-999x1920-EEE-FFFFFF-t=Some%20Random%20Text", ZenType.HTML);

            string expected = "http://placehold.it/999x1920/EEE/FFFFFF/&text=Some%20Random%20Text";

            StringAssert.Contains(result, expected);
        }

        [TestMethod]
        public void PlaceHold5()
        {
            string result = _parser.Parse("place-20000x3599-t=SomeRandomText", ZenType.HTML);
            string expected = "<img src=\"http://placehold.it/790x1678/&text=SomeRandomText\" alt=\"\" />"; // the allowed bound is 0-1920

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void PlaceHoldWithAttributes()
        {
            string result = _parser.Parse("place[alt=\"tag's here\" title=\"picture title\" data-foo=\"bar\"]", ZenType.HTML);
            string expected = "<img src=\"http://placehold.it/30x30/\" alt=\"tag's here\" title=\"picture title\" data-foo=\"bar\" />";

            Assert.AreEqual(expected, result);
        }

    }
}
