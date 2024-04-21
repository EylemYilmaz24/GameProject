using ENTITES.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAPP.Configuration
{
    public class CharConfig: IEntityTypeConfiguration<Character>
    {
        public void Configure(EntityTypeBuilder<Character> builder)
        {
            builder.ToTable("Characters");
            builder.HasKey(x => x.ID);

            builder.Property(x => x.CharName).IsRequired().HasColumnName("Karakter İsmi");
            builder.Property(x => x.Power).IsRequired().HasColumnName("Güç Durumu");
            builder.Property(x => x.Speed).IsRequired().HasColumnName("Hız Durumu");
            builder.Property(x => x.Healty).IsRequired().HasColumnName("Sağlık Durumu");
            builder.Property(x => x.Level).IsRequired().HasColumnName("Seviye");
            builder.Property(x => x.CharClass).IsRequired().HasColumnName("Karakter Sınıfı");
            builder.Property(x => x.Nation).IsRequired().HasColumnName("Karakter Irkı");
        }


    }
}
