using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AWCodeOnlyData
{
    public class EmployeeAddress
    {
        public EmployeeAddress() { }
        public Guid rowguid  { get; set; }
        public DateTime ModifiedDateTime  { get; set; }
        public int EmployeeID { get; set; }
        public int AddressID { get; set; }
        public ICollection<Employee> Employee { get; set; }
        public ICollection<Address> Address { get; set; }
    }
}
