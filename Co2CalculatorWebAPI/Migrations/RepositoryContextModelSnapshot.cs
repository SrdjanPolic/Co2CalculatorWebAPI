﻿// <auto-generated />
using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Co2CalculatorWebAPI.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    partial class RepositoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("Entities.Models.Culture", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("CultureId");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Cultures");
                });

            modelBuilder.Entity("Entities.Models.CultureInput", b =>
                {
                    b.Property<Guid>("CultureId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("InputId")
                        .HasColumnType("char(36)");

                    b.HasKey("CultureId", "InputId");

                    b.HasIndex("InputId");

                    b.ToTable("CultureInputs");
                });

            modelBuilder.Entity("Entities.Models.Input", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("InputId");

                    b.Property<decimal>("Co2EqPerKgAppliance")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("Co2EqPerKgProduction")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("Co2EqPerUnit")
                        .HasColumnType("decimal(65,30)");

                    b.Property<Guid>("InputTypeId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("InputTypeId");

                    b.ToTable("Inputs");
                });

            modelBuilder.Entity("Entities.Models.InputType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("InputTypeId");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("InputType");
                });

            modelBuilder.Entity("Entities.Models.CultureInput", b =>
                {
                    b.HasOne("Entities.Models.Culture", "Culture")
                        .WithMany("CultureInputs")
                        .HasForeignKey("CultureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Models.Input", "Input")
                        .WithMany("CultureInputs")
                        .HasForeignKey("InputId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Culture");

                    b.Navigation("Input");
                });

            modelBuilder.Entity("Entities.Models.Input", b =>
                {
                    b.HasOne("Entities.Models.InputType", "InputType")
                        .WithMany("Inputs")
                        .HasForeignKey("InputTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InputType");
                });

            modelBuilder.Entity("Entities.Models.Culture", b =>
                {
                    b.Navigation("CultureInputs");
                });

            modelBuilder.Entity("Entities.Models.Input", b =>
                {
                    b.Navigation("CultureInputs");
                });

            modelBuilder.Entity("Entities.Models.InputType", b =>
                {
                    b.Navigation("Inputs");
                });
#pragma warning restore 612, 618
        }
    }
}
