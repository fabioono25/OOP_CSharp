using ACM.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACM
{
    //Repository class USES AN entity to return and save (Collaboration)
    public class CustomerRepository
    {
        private AddressRepository addressRepository { get; set; }

        public CustomerRepository()
        {
            this.addressRepository = new AddressRepository();
        }

        /// <summary>
        /// return one customer
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Customer Retrieve(int customerId)
        {
            var customer = new Customer(1);
            //collaborative relationship between customer repository and address repository
            customer.AddressList = addressRepository.
                RetrieveByCustomerId(customerId).ToList();
            if (customerId == 1)
            {
                customer.EmailAddress = "a";
                customer.FirstName = "joao";
                customer.LastName = "jaja";
            }

            return customer;
        }

        /// <summary>
        /// return a list of customers
        /// </summary>
        /// <returns></returns>
        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        //
        public bool Save(Customer customer)
        {
            return true;
        }
    }
}
