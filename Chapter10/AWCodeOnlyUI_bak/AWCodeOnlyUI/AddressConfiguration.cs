using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Data.Objects;
using AWCodeOnlyData;

namespace AWCodeOnlyUI
{
    class AddressConfiguration : EntityConfiguration<Address>
    {
        public AddressConfiguration(ContextBuilder<AWModel> cb)
        {
            Property(a => a.AddressID).IsIdentity();
            Property(a => a.AddressLine1).HasMaxLength(60);
            Property(a => a.AddressLine2).HasMaxLength(60);
            Property(a => a.City).HasMaxLength(30);
            Property(a => a.State).HasMaxLength(2);
            Property(a => a.PostalCode).HasMaxLength(15);
        }
    }
}
