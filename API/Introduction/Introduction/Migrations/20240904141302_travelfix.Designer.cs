﻿// <auto-generated />
using System;
using Introduction.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Introduction.Migrations
{
    [DbContext(typeof(CountriesDbContext))]
    [Migration("20240904141302_travelfix")]
    partial class travelfix
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Introduction.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("city_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CityCode")
                        .IsRequired()
                        .HasColumnType("char(8)")
                        .HasColumnName("city_code");

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("city_name");

                    b.Property<int>("CountryId")
                        .HasColumnType("int")
                        .HasColumnName("country_id");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("city");
                });

            modelBuilder.Entity("Introduction.Models.Continent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("continent_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ContinentArea")
                        .HasColumnType("int")
                        .HasColumnName("continent_area");

                    b.Property<string>("ContinentName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("continent_name");

                    b.HasKey("Id");

                    b.ToTable("continent");
                });

            modelBuilder.Entity("Introduction.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("country_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ContinentId")
                        .HasColumnType("int")
                        .HasColumnName("continent_id");

                    b.Property<string>("CountryCode")
                        .IsRequired()
                        .HasColumnType("char(2)")
                        .HasColumnName("country_code");

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("country_name");

                    b.HasKey("Id");

                    b.HasIndex("ContinentId");

                    b.ToTable("country");
                });

            modelBuilder.Entity("Introduction.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("person_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("person_firstname");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("person_lastname");

                    b.HasKey("Id");

                    b.ToTable("people");
                });

            modelBuilder.Entity("Introduction.Models.Travel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("travel_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CityEndId")
                        .HasColumnType("int")
                        .HasColumnName("travel_end_city_id");

                    b.Property<int>("CityStartId")
                        .HasColumnType("int")
                        .HasColumnName("travel_start_city_id");

                    b.Property<DateTime>("TravelEndDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("travel_end_date");

                    b.Property<DateTime>("TravelStartDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("travel_start_date");

                    b.HasKey("Id");

                    b.HasIndex("CityEndId");

                    b.HasIndex("CityStartId");

                    b.ToTable("travel");
                });

            modelBuilder.Entity("Introduction.Models.City", b =>
                {
                    b.HasOne("Introduction.Models.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Introduction.Models.Country", b =>
                {
                    b.HasOne("Introduction.Models.Continent", "Continent")
                        .WithMany("Countries")
                        .HasForeignKey("ContinentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Continent");
                });

            modelBuilder.Entity("Introduction.Models.Travel", b =>
                {
                    b.HasOne("Introduction.Models.City", "CityEnd")
                        .WithMany()
                        .HasForeignKey("CityEndId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Introduction.Models.City", "CityStart")
                        .WithMany()
                        .HasForeignKey("CityStartId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("CityEnd");

                    b.Navigation("CityStart");
                });

            modelBuilder.Entity("Introduction.Models.Continent", b =>
                {
                    b.Navigation("Countries");
                });

            modelBuilder.Entity("Introduction.Models.Country", b =>
                {
                    b.Navigation("Cities");
                });
#pragma warning restore 612, 618
        }
    }
}
