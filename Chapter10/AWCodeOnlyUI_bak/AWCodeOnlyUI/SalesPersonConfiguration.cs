using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Data.Objects;
using AWCodeOnlyData;

namespace AWCodeOnlyUI
{
    class SalesPersonConfiguration : EntityConfiguration<SalesPerson>
    {
        public SalesPersonConfiguration(ContextBuilder<AWModel> cb)
        {
            Relationship(sp => sp.Employee).IsRequired();
            //Relationship(sp => sp.SalesTerritories).IsRequired();

            //Relationship(sp => sp.TerritoryID).FromProperty(sp => sp.SalesTerritory);
        }
    }
}
