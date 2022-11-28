﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NordicDoorWeb.DataAccess;

#nullable disable

namespace NordicDoorWeb.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221127134258_AddForslagToDb")]
    partial class AddForslagToDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NordicDoor.Models.Forslag", b =>
                {
                    b.Property<int>("ForslagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ForslagId"));

                    b.Property<string>("AnsattId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ansvarlig")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DatoRegistrert")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Frist")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Løsning")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mål")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Team")
                        .HasColumnType("int");

                    b.Property<string>("Tittel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Årsak")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ForslagId");

                    b.ToTable("Forslags");
                });

            modelBuilder.Entity("NordicDoor.Models.Suggestion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Deadline")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Suggestions");
                });
#pragma warning restore 612, 618
        }
    }
}