﻿// <auto-generated />
using MAPP.Contextt;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AAMAP.Migrations
{
    [DbContext(typeof(Contextt))]
    [Migration("20240421215146_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ENTITES.Models.Character", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("CharClass")
                        .HasColumnType("int")
                        .HasColumnName("Karakter Sınıfı");

                    b.Property<string>("CharName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Karakter İsmi");

                    b.Property<int>("Healty")
                        .HasColumnType("int")
                        .HasColumnName("Sağlık Durumu");

                    b.Property<int>("Level")
                        .HasColumnType("int")
                        .HasColumnName("Seviye");

                    b.Property<int>("Nation")
                        .HasColumnType("int")
                        .HasColumnName("Karakter Irkı");

                    b.Property<int>("Power")
                        .HasColumnType("int")
                        .HasColumnName("Güç Durumu");

                    b.Property<int>("ProfileId")
                        .HasColumnType("int");

                    b.Property<int>("Speed")
                        .HasColumnType("int")
                        .HasColumnName("Hız Durumu");

                    b.HasKey("ID");

                    b.HasIndex("ProfileId");

                    b.ToTable("Characters", (string)null);
                });

            modelBuilder.Entity("ENTITES.Models.Profile", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.HasKey("ID");

                    b.ToTable("Profiles", (string)null);
                });

            modelBuilder.Entity("ENTITES.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Şifre");

                    b.Property<int>("ProfileID")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Kullanıcı İsmi");

                    b.HasKey("ID");

                    b.HasIndex("ProfileID");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("ENTITES.Models.Character", b =>
                {
                    b.HasOne("ENTITES.Models.Profile", "Profile")
                        .WithMany("Characters")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("ENTITES.Models.User", b =>
                {
                    b.HasOne("ENTITES.Models.Profile", "Profile")
                        .WithMany("Users")
                        .HasForeignKey("ProfileID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("ENTITES.Models.Profile", b =>
                {
                    b.Navigation("Characters");

                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
