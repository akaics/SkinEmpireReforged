﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SkinEmpireReforged.Data;

#nullable disable

namespace SkinEmpireReforged.Migrations
{
    [DbContext(typeof(TwinsDbContext))]
    [Migration("20231221042621_FirstMigration")]
    partial class FirstMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<double>("Pris")
                        .HasColumnType("float");

                    b.Property<string>("SkinNavn")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Stand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VåbenType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BrugerId");

                    b.ToTable("Brugere");
                });

            modelBuilder.Entity("SkinEmpireReforged.Model.Skin", b =>
                {
                    b.Property<int>("SkinId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SkinId"));

                    b.Property<string>("Beskrivelse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BrugerId")
                        .HasColumnType("int");

                    b.Property<double>("Pris")
                        .HasColumnType("float");

                    b.Property<string>("SkinNavn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SkinTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Stand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VåbenType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SkinId");

                    b.HasIndex("BrugerId");

                    b.HasIndex("SkinTypeId");

                    b.ToTable("Skins");
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
                    b.HasOne("SkinEmpireReforged.Model.Bruger", "Bruger")
                        .WithMany("Skins")
                        .HasForeignKey("BrugerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SkinEmpireReforged.Model.SkinType", null)
                        .WithMany("Skins")
                        .HasForeignKey("SkinTypeId");

                    b.Navigation("Bruger");
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
