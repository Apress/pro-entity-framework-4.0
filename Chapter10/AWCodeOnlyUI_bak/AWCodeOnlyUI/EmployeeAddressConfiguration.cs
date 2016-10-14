using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Data.Objects;
using AWCodeOnlyData;

namespace AWCodeOnlyUI
{
    class EmployeeAddressConfiguration : EntityConfiguration<EmployeeAddress>
    {
        public EmployeeAddressConfiguration(ContextBuilder<AWModel> cb)
        {
            try
            {
                cb.Entity<EmployeeAddress>().HasKey(ea => new { ea.EmployeeID, ea.AddressID });
                //Property(ea => ea.AddressID).com
                Relationship(ea => ea.Employee).IsRequired();
                Relationship(ea => ea.Address).IsRequired();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Relationship(ea => ea.EmployeeID).FromProperty(e => e.);
            //Relationship(ea => ea.AddressID).FromProperty(e => e.Address);
        }
    }
}
