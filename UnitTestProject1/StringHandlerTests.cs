using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.Common.Tests
{
    [TestClass]
    public class StringHandlerTests
    {
        [TestMethod]
        public void InsertSpaces_Method_Returns_String_With_Spaces_Between_Each_Word_When_Source_Is_A_Concatenated_String_Of_Words()
        {
            //Arrange
            string expected = "Sonic Screwdriver";
            string source = "SonicScrewdriver";

            //Act
            string actual = source.InsertSpaces();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertSpaces_Method_Does_Not_Add_Space_Before_Words_Where_Spaces_Already_Exist()
        {
            //Arrange
            var source = "Sonic Screwdriver";
            var expected = "Sonic Screwdriver";


            //Act
            var actual = source.InsertSpaces();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }

    
}
