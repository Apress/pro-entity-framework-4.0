using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeOnlyData
{
    public class Employee
    {
        public Employee() { }
        public int EmployeeID { get; set; }
        public string NationalIDNumber { get; set; }
        public string LoginID { get; set; }
        public Nullable<int> ManagerID { get; set; }
        public string Title { get; set; }
        public DateTime BirthDate { get; set; }
        public string MaritalStatus { get; set; }
        public string Gender { get; set; }
        public DateTime HireDate { get; set; }
        public bool SalariedFlag { get; set; }
        public short VacationHours { get; set; }
        public short SickLeaveHours { get; set; }
        public bool CurrentFlag { get; set; }
        public Guid rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }
        public virtual Contact Contact { get; set; }

        public virtual ICollection<SalesPerson> SalesPeople { get; set; }

    }
}
