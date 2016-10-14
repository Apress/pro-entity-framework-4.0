using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Data.Objects;
using AWCodeOnlyData;

namespace AWCodeOnlyUI
{
    class EmployeeConfiguration : EntityConfiguration<Employee>
    {
        public EmployeeConfiguration(ContextBuilder<AWModel> cb)
        {
            Property(e => e.EmployeeID).IsIdentity();
            Property(e => e.NationalIDNumber).HasMaxLength(15);
            Property(e => e.LoginID).HasMaxLength(256);
            Property(e => e.Title).HasMaxLength(50);
            //Property(e => e.BirthDate)
            Property(e => e.MaritalStatus).HasMaxLength(1);
            Property(e => e.Gender).HasMaxLength(1);
            //Property(e => e.HireDate)
            //Property(e => e.SalariedFlag)
            //Property(e => e.VacationHours)
            //Property(e => e.SickLeaveHours)
            //Property(e => e.CurrentFlag)

            Relationship(e => e.Contact).IsRequired();
            Relationship(e => e.SalesPerson).IsRequired();
            Relationship(e => e.EmployeeAddresses).IsRequired();

            //Relationship(e => e.ContactID).FromProperty(c => c.e);
        }
    }
}
