using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Data.Objects;
using AWCodeOnlyData;

namespace AWCodeOnlyUI
{
    class ContactConfiguration : EntityConfiguration<Contact>
    {
        public ContactConfiguration(ContextBuilder<AWModel> cb)
        {
            Property(c => c.ContactID).IsIdentity();
            //Property(c => c.NameStyle)
            Property(c => c.Title).HasMaxLength(8);
            Property(c => c.FirstName).HasMaxLength(50);
            Property(c => c.MiddleName).HasMaxLength(50);
            Property(c => c.LastName).HasMaxLength(50);
            Property(c => c.Suffix).HasMaxLength(10);
            Property(c => c.EmailAddress).HasMaxLength(50);
            //Property(c => c.EmailPromotion)
            Property(c => c.Phone).HasMaxLength(25);
            Property(c => c.PasswordHash).HasMaxLength(128);
            Property(c => c.PasswordSalt).HasMaxLength(10);
        }
    }
}
