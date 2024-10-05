
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankManager.Infrastructure.Configurations
{
    public class BloodStorageConfiguration:IEntityTypeConfiguration<BloodBankManager>
    {
        public void Configure(EntityTypeBuilder<BloodStorage> builder)
        {
            builder
                .Haskey(s => s.Id);

            builder
                .Property(p => p.TipoSanguineo)
                .HasConversion(b => b.ToString(), b => (TipoSanguineo)Enum.Parse(typeof(TipoSanguineo), b));

            builder
                .Property(r => r.FatorRh)
                .HasConversion(r => r.ToString(), r => (FatorRh)Enum.Parse(typeof(FatorRh), r));
        }
    }
}
