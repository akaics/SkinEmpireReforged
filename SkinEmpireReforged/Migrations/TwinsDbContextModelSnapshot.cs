﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SkinEmpireReforged.Data;

#nullable disable

namespace SkinEmpireReforged.Migrations
{
    [DbContext(typeof(TwinsDbContext))]
    partial class TwinsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SkinEmpireReforged.Model.Bruger", b =>
                {
                    b.Property<int>("BrugerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BrugerId"));

                    b.Property<string>("Rolle")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("BrugerId");

                    b.ToTable("Brugere");
                });

            modelBuilder.Entity("SkinEmpireReforged.Model.Skin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Beskrivelse")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("BrugerId")
                        .HasColumnType("int");

                    b.Property<decimal>("Pris")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("SkinNavn")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("SkinTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Stand")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("VåbenType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("BrugerId");

                    b.HasIndex("SkinTypeId");

                    b.ToTable("Skin");
                });

            modelBuilder.Entity("SkinEmpireReforged.Model.SkinType", b =>
                {
                    b.Property<int>("SkinTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SkinTypeId"));

                    b.Property<string>("Rarity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SkinTypeId");

                    b.ToTable("SkinTypes");
                });

            modelBuilder.Entity("SkinEmpireReforged.Model.Skin", b =>
                {
                    b.HasOne("SkinEmpireReforged.Model.Bruger", null)
                        .WithMany("Skins")
                        .HasForeignKey("BrugerId");

                    b.HasOne("SkinEmpireReforged.Model.SkinType", null)
                        .WithMany("Skins")
                        .HasForeignKey("SkinTypeId");
                });

            modelBuilder.Entity("SkinEmpireReforged.Model.Bruger", b =>
                {
                    b.Navigation("Skins");
                });

            modelBuilder.Entity("SkinEmpireReforged.Model.SkinType", b =>
                {
                    b.Navigation("Skins");
                });
#pragma warning restore 612, 618
        }
    }
}
