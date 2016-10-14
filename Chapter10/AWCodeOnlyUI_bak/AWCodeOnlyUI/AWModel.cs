using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using System.Data.EntityClient;
using AWCodeOnlyData;

namespace AWCodeOnlyUI
{
    public class AWModel : ObjectContext
    {
        public AWModel(EntityConnection connection)
            : base(connection)
        {
            DefaultContainerName = "AWModel";
        }

        public IObjectSet<Contact> Contact
        {
            get { return base.CreateObjectSet<Contact>(); }
        }

        public IObjectSet<Employee> Employee
        {
            get { return base.CreateObjectSet<Employee>(); }
        }

        public IObjectSet<EmployeeAddress> EmployeeAddress
        {
            get { return base.CreateObjectSet<EmployeeAddress>(); }
        }

        public IObjectSet<Address> Address
        {
            get { return base.CreateObjectSet<Address>(); }
        }

        public IObjectSet<SalesPerson> SalesPerson
        {
            get { return base.CreateObjectSet<SalesPerson>(); }
        }

        public IObjectSet<SalesTerritory> SalesTerritory
        {
            get { return base.CreateObjectSet<SalesTerritory>(); }
        }
    }
}
