using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AWCodeOnlyData
{
    public class Address
    {
        public Address() { }
        public int AddressID { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public Guid rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }
        public ICollection<EmployeeAddress> EmployeeAddresses { get; set; }
    }
}
