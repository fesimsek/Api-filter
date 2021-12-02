using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebApplication5.Mapping
{
    public class IlMap : IEntityTypeConfiguration<Il>
    {
        public void Configure(EntityTypeBuilder<Il> builder)
        {
            builder.Property(c => c.Id)
                .HasColumnName("Id");

            

        }
    }

    
}
