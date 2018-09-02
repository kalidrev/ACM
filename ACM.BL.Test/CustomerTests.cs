using ACM.BL;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BL.Test
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod()]
        public void FullName_Property_Returns_LastName_Comma_Space_FirstName()
        {
            //Arrange
            Customer customer = new Customer();
            customer.FirstName = "Bilbo";
            customer.LastName = "Baggins";

            string expected = "Baggins, Bilbo";

            //Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void FullName_Property_Returns_Only_LastName_When_FirstName_Is_Empty()
        {
            //Arrange
            Customer customer = new Customer();
            customer.LastName = "Baggins";

            string expected = "Baggins";

            //Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FullName_Property_Returns_Only_FirstName_When_LastName_Is_Empty()
        {
            //Arrange
            Customer customer = new Customer();
            customer.FirstName = "Bilbo";

            string expected = "Bilbo";

            //Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Validate_Method_Returns_True_When_LastName_And_EmailAddress_Contain_Character_Strings()
        {
            //Arrange
            var customer = new Customer();
            customer.LastName = "Baggins";
            customer.EmailAddress = "fbaggins@hobbiton.me";

            var expected = true;

            //Act
            var actual = customer.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Validate_Method_Returns_False_When_LastName_Is_Missing()
        {
            //Arrange
            var customer = new Customer();
            customer.EmailAddress = "fbaggins@hobbiton.me";

            var expected = false;

            //Act
            var actual = customer.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Validate_Method_Returns_False_When_EmailAddress_Is_Missing()
        {
            //Arrange
            var customer = new Customer();
            customer.FirstName = "Frodo";

            var expected = false;

            //Act
            var actual = customer.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Validate_Method_Returns_False_When_LastName_And_EmailAddress_Are_Missing()
        {
            //Arrange
            var customer = new Customer();

            var expected = false;

            //Act
            var actual = customer.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void x()
        {
            //Arrange
            var c1 = new Customer();
            c1.FirstName = "Bilbo";
            Customer.InstanceCount++;

            var c2 = new Customer();
            c2.FirstName = "Frodo";
            Customer.InstanceCount++;

            var c3 = new Customer();
            c3.FirstName = "Rosie";
            Customer.InstanceCount++;

            //Act


            //Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }
    }
}
