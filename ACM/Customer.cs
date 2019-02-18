using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer
    {
        //default constructor
        public Customer()
        {

        }

        public Customer(int customerId)
        {
            this.CustomerId = customerId;
        }

        //this member belongs to the type itself
        public static int InstanceCount { get; set; }

        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        //if don't need any logic in getters and setters
        public string FirstName { get; set; }

        public string EmailAddress { get; set; }

        //any code external to this class cannot use set
        public int CustomerId { get; private set; }

        public string FullName
        {
            get {

                var fullName = LastName;

                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                        fullName += ", ";

                    fullName += FirstName;
                }

                return fullName;
            }
        }

        //validate the state of the object
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

        public bool Save()
        {
            return true;
        }

        /// <summary>
        /// return one customer
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Customer Retrieve(int customerId)
        {
            return new Customer();
        }

        /// <summary>
        /// return a list of customers
        /// </summary>
        /// <returns></returns>
        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }
    }
}
