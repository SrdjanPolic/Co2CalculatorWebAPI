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

                    b.HasData(
                        new
                        {
                            Id = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                            Name = "Corn"
                        },
                        new
                        {
                            Id = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                            Name = "Wheat"
                        },
                        new
                        {
                            Id = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                            Name = "Ray"
                        });
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

                    b.Property<decimal>("Co2EqPerKgCoefficient")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("Co2KgPerHa")
                        .HasColumnType("decimal(65,30)");

                    b.Property<Guid>("InputTypeId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("InputTypeId");

                    b.ToTable("Inputs");

                    b.HasData(
                        new
                        {
                            Id = new Guid("47f0b104-dd1c-4775-be36-5503ce49794b"),
                            Co2EqPerKgCoefficient = 9.78m,
                            Co2KgPerHa = 0m,
                            InputTypeId = new Guid("242e5514-ce39-4647-ad4d-a81516be7def"),
                            Name = "NitrogenFertilizer"
                        },
                        new
                        {
                            Id = new Guid("2499f832-0843-4e0c-8beb-1ef53adecb00"),
                            Co2EqPerKgCoefficient = 0.73m,
                            Co2KgPerHa = 0m,
                            InputTypeId = new Guid("242e5514-ce39-4647-ad4d-a81516be7def"),
                            Name = "Urea"
                        },
                        new
                        {
                            Id = new Guid("3b32f09f-9ae3-4045-9f95-75300fe179b0"),
                            Co2EqPerKgCoefficient = 0.16m,
                            Co2KgPerHa = 0m,
                            InputTypeId = new Guid("242e5514-ce39-4647-ad4d-a81516be7def"),
                            Name = "KaliumFertilizer"
                        },
                        new
                        {
                            Id = new Guid("9540bca3-a5db-4729-abb5-9d5593ad7568"),
                            Co2EqPerKgCoefficient = 4.5m,
                            Co2KgPerHa = 0m,
                            InputTypeId = new Guid("242e5514-ce39-4647-ad4d-a81516be7def"),
                            Name = "PhosphorusFertilizer"
                        },
                        new
                        {
                            Id = new Guid("1b7252ec-fe35-42df-9a6e-395ba4e6d7f0"),
                            Co2EqPerKgCoefficient = 0m,
                            Co2KgPerHa = 4000m,
                            InputTypeId = new Guid("72574ea7-47c4-4248-9a49-dde040ac47c1"),
                            Name = "Soil1"
                        });
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

                    b.HasData(
                        new
                        {
                            Id = new Guid("72574ea7-47c4-4248-9a49-dde040ac47c1"),
                            Name = "Soil"
                        },
                        new
                        {
                            Id = new Guid("b9dc67b4-df69-41fe-b06b-3294a939a0e0"),
                            Name = "Fuel"
                        },
                        new
                        {
                            Id = new Guid("9b572fc7-4e71-400b-b66e-528b5dc90106"),
                            Name = "Pesticide"
                        },
                        new
                        {
                            Id = new Guid("242e5514-ce39-4647-ad4d-a81516be7def"),
                            Name = "Fertilizer"
                        });
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
