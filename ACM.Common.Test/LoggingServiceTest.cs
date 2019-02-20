using ACM.BL;
using ACM.Common;
using NUnit.Framework;
using System.Collections.Generic;

namespace ACM.Common.Test
{
    public class LoggingServiceTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void WriteToFileTest()
        {
            //arrange
            var changedItems = new List<ILoggable>();

            var customer = new Customer(1)
            {
                EmailAddress = "joao"
            };

            changedItems.Add(customer as ILoggable); //why as ILoggable

            //act
            LoggingService.WriteToFile(changedItems);

            //assert
            //nothing here to assert
        }
    }
}
