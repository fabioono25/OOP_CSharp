using ACM.Common;
using System;
using System.Collections.Generic;

namespace ACM.BL
{
    //do same for Order and Product
    public class Customer : EntityBase, ILoggable
    {
        //default constructor
        public Customer()
            : this(0) //constructor chaining
        {

        }
        //Customer HAS A Home Address and a Work Address (Composition)
        //public Address WorkAddress { get; set; }
        //public Address HomeAddress { get; set; }
        public List<Address> AddressList { get; set; } //the list doesn't have a good default value. default null

        public int CustomerType { get; set; } //defining a type for our customer, without using inheritance yet

        public Customer(int customerId)
        {
            this.CustomerId = customerId;
            AddressList = new List<Address>();
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
        //public bool Validate()
        //{
        //    var isValid = true;

        //    if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
        //    if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

        //    return isValid;
        //}

        public override string ToString()
        {
            return FullName;
        }

        public string Log()
        {
            var logging = this.CustomerId + ": " + this.FullName;

            return logging;
        }

        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }
    }
}
