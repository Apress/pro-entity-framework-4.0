using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Data.Objects;
using CodeOnlyData;

namespace CodeOnlyUI
{
    class EmployeeConfiguration : EntityConfiguration<Employee>
    {
        public EmployeeConfiguration(ContextBuilder<AWModel> cb)
        {
            Property(e => e.EmployeeID).IsIdentity();
            Property(e => e.NationalIDNumber).HasMaxLength(15).IsRequired();
            Property(e => e.LoginID).HasMaxLength(256).IsRequired();
            Property(e => e.Title).HasMaxLength(50).IsRequired();
            Property(e => e.MaritalStatus).HasMaxLength(1).IsRequired();
            Property(e => e.Gender).HasMaxLength(1).IsRequired();

            Relationship(e => e.Contact).IsRequired();

            Relationship(e => e.Contact).FromProperty(c => c.Employees);
        }
    }
}
