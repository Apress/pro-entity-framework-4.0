using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace CodeOnlyData
{
    public class SalesPerson
    {
        public SalesPerson() {}
        public int SalesPersonID { get; set; }
        public int TerritoryID { get; set; }
        public decimal SalesQuota { get; set; }
        public decimal Bonus { get; set; }
        public decimal CommissionPct { get; set; }
        public decimal SalesYTD { get; set; }
        public decimal SalesLastYear { get; set; }
        public Guid rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual SalesTerritory SalesTerritory { get; set; }
    }
}
