using BloodBankManager.Entities;
using BloodBankManager.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankManager.Infrastructure.Configurations
{
    public class DonorConfiguration: IEntityTypeConfiguration<Donor>
    {
        public void Configure(EntityTypeBuilder<Donor> builder)
        {
            builder
                 .HasKey(d => d.Id);

            builder
                .HasMany(d => d.Donations)
                .WithOne(d => d.Donor)
                .HasForeignKey(d => d.DonorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .OwnsOne(e => e.Endereco)
                .Property(e => e.Estado)
                .HasColumnName("Estado");


            builder
                .OwnsOne(e => e.Endereco)
                .Property(e => e.Estado)
                .HasColumnName("Estado");

            builder
                .OwnsOne(e => e.Endereco)
                .Property(c => c.Cidade)
                .HasColumnName("Cidade");

            builder
                .OwnsOne(e => e.Endereco)
                .Property(c => c.CEP)
                .HasColumnName("CEP");

            builder
                .Property(g => g.Genero)
                .HasConversion(g => g.ToString(), g => (Genero)Enum.Parse(typeof(Genero), g));

            builder
                .Property(p => p.TipoSanguineo)
                .HasConversion(b => b.ToString(), b => (TipoSanguineo)Enum.Parse(typeof(TipoSanguineo), b));

            builder
                .Property(r => r.FatorRh)
                .HasConversion(r => r.ToString(), r => (FatorRh)Enum.Parse(typeof(FatorRh), r));
        }
    }
}
