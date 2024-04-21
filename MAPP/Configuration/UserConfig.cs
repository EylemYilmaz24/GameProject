using ENTITES.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAPP.Configuration
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            

            builder.Property(x => x.UserName).IsRequired().HasColumnName("Kullanıcı İsmi");
            builder.Property(x => x.Password).IsRequired().HasColumnName("Şifre");
        }
    }
}
