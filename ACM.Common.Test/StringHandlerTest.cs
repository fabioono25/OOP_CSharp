using ACM.Common;
using NUnit.Framework;

namespace Tests
{
    public class StringHandlerTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void InsertSpaces()
        {
            //arrange
            var source = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";

            //var handler = new StringHandler();

            //act
            //var actual = StringHandler.InsertSpaces(source);
            var actual = source.InsertSpaces();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void InsertSpacesTestWithExistingSpace()
        {
            //arrange
            var source = "Sonic Screwdriver";
            var expected = "Sonic Screwdriver";

            //var handler = new StringHandler();

            //act
            //var actual = StringHandler.InsertSpaces(source);
            var actual = source.InsertSpaces();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}