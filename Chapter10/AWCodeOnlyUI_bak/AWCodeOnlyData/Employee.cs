using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AWCodeOnlyData
{
    public class Employee
    {
        public Employee() { }
        public int EmployeeID { get; set; }
        public string NationalIDNumber { get; set; }
        public string LoginID { get; set; }
        public int ManagerID { get; set; }
        public string Title { get; set; }
        public DateTime BirthDate { get; set; }
        public string MaritalStatus { get; set; }
        public string Gender { get; set; }
        public DateTime HireDate { get; set; }
        public bool SalariedFlag { get; set; }
        public int VacationHours { get; set; }
        public int SickLeaveHours { get; set; }
        public bool CurrentFlag { get; set; }
        public Guid rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Contact Contact { get; set; }
        //public ICollection<EmployeeAddress> EmployeeAddresses { get; set; }
        //public SalesPerson SalesPerson { get; set; }
        //public int ContactID { get; set; }

        //public System.Data.Objects.DataClasses.EntityReference<Contact> ContactReference { get; set; }
        //public System.Data.Objects.DataClasses.EntityReference<SalesPerson> SalesPersonReference { get; set; } 
    }
}
