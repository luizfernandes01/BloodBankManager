using BloodBankManager.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankManager.Infrastructure.Configurations
{
    public class DonationConfiguration : IEntityTypeConfiguration<Donation>
    {
        public void Configure(EntityTypeBuilder<Donation> builder)
        {
            builder
                .HasKey(d => d.Id);

            builder
                .HasOne(d => d.Donor)
                .WithMany(d => d.Donations)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}