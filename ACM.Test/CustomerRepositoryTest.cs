using ACM.BL;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace ACM.Test
{
    public class CustomerRepositoryTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void RetrieveExisting()
        {
            //arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "a",
                FirstName = "joao",
                LastName = "jaja"
            };

            //act
            var actual = customerRepository.Retrieve(1);

            //assert
            //Assert.AreEqual(expected, actual); //error, instances differents

            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
        }

        [Test]
        public void RetrieveExistingWithAddress()
        {
            //arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "a",
                FirstName = "joao",
                LastName = "jaja",
                AddressList = new List<Address>() //collection initializers
                {
                    new Address(),
                    new Address()
                }
            };

            //act
            var actual = customerRepository.Retrieve(1);

            //assert
            //Assert.AreEqual(expected, actual); //error, instances differents
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);

            //implement verification for each address with for  
        }
    }
}
