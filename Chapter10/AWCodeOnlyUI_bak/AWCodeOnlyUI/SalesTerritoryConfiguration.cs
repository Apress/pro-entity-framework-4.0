using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Data.Objects;
using AWCodeOnlyData;

namespace AWCodeOnlyUI
{
    class SalesTerritoryConfiguration : EntityConfiguration<SalesTerritory>
    {
        public SalesTerritoryConfiguration(ContextBuilder<AWModel> cb)
        {
            cb.Entity<SalesTerritory>().HasKey(st => new { st.TerritoryID });
            Property(st => st.TerritoryID).IsIdentity();
            Property(st => st.Name).HasMaxLength(50);
            Property(st => st.CountryRegionCode).HasMaxLength(3);
            Property(st => st.Group).HasMaxLength(50);
        }
    }
}
