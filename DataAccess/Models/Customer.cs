﻿namespace DataAccess.Models
{
    internal class Customer
    {
        public int CustomerID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string EMailAdress { get; set; }
        public string PhoneNumber { get; set; }
        public string Fax { get; set; }
        public string Country { get; set; }
    }
}
