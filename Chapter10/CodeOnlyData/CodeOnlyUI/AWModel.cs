using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using System.Data.EntityClient;
using CodeOnlyData;

namespace CodeOnlyUI
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
    }
}
