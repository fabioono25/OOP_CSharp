using System;
using System.Collections.Generic;
using System.Text;

namespace ACM
{
    public class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            var address = new Address(1);

            return address;
        }

        //recomended way IEnumerable (flexible)
        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();

            return addressList;
        }

        public bool Save(Address address)
        {
            return true;
        }
    }
}
