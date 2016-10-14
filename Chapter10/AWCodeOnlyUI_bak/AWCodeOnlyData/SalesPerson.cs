using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Objects;
using System.Text;

namespace AWCodeOnlyData
{
    public class SalesPerson
    {
        public SalesPerson() { }
        public int SalesPersonID { get; set; }
        public int TerritoryID { get; set; }
        public decimal SalesQuota { get; set; }
        public decimal Bonus { get; set; }
        public decimal CommissionPct { get; set; }
        public decimal SalesYTD { get; set; }
        public decimal SalesLastYear { get; set; }
        public Guid rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Employee Employee { get; set; }
        public SalesTerritory SalesTerritory { get; set; }
        public ICollection<Employee> Employees { get; set; }
        //public ICollection<SalesTerritory> SalesTerritories { get; set; }
    }
}
