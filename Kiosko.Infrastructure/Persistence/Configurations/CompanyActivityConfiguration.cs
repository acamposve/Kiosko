using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kiosko.Domain.Entities;

namespace Kiosko.Infrastructure.Persistence.Configurations
{
    public class CompanyActivityConfiguration : IEntityTypeConfiguration<CompanyActivity>
    {
        public void Configure(EntityTypeBuilder<CompanyActivity> builder)
        {
            builder.Property(t => t.ActivityName)
                .HasMaxLength(200)
                .IsRequired();
        }
    }

}
