using ACM.BL;
using NUnit.Framework;

namespace Tests
{
    public class CustomerTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FullNameTestValid()
        {
            //arrange
            var customer = new Customer();
            customer.FirstName = "Bilbo";
            customer.LastName = "Bolseiro";

            string expected = "Bolseiro, Bilbo";

            //act 
            string actual = customer.FullName;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FullNameFirstNameEmpty()
        {
            //arrange
            var customer = new Customer();
            customer.LastName = "Bolseiro";

            string expected = "Bolseiro";

            //act 
            string actual = customer.FullName;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FullNameLastNameEmpty()
        {
            //arrange
            var customer = new Customer(); //implicit typed object
            customer.FirstName = "Bilbo";

            string expected = "Bilbo";

            //act 
            string actual = customer.FullName;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void StaticTest()
        {
            //arrange
            var c1 = new Customer();
            c1.FirstName = "Bilbo";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Frodo";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Rosie";
            Customer.InstanceCount += 1;

            //act

            //assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [Test]
        public void ValidateValid()
        {
            //arrange
            var customer = new Customer();
            customer.LastName = "Bolseiro";
            customer.EmailAddress = "bilbo@bolseiro.com";

            var expected = true;

            //act
            var actual = customer.Validate();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidateMissingLastName()
        {
            //arrange
            var customer = new Customer();
            customer.EmailAddress = "bilbo@bolseiro.com";

            var expected = false;

            //act
            var actual = customer.Validate();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}