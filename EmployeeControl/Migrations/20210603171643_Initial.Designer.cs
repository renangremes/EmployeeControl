﻿// <auto-generated />
using System;
using EmployeeControl.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmployeeControl.Migrations
{
    [DbContext(typeof(EmployeeControlContext))]
    [Migration("20210603171643_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.6");

            modelBuilder.Entity("EmployeeControl.Models.Employees", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CPF")
                        .HasColumnType("text");

                    b.Property<string>("PIS")
                        .HasColumnType("text");

                    b.Property<string>("RG")
                        .HasColumnType("text");

                    b.Property<string>("address")
                        .HasColumnType("text");

                    b.Property<string>("celPhone")
                        .HasColumnType("text");

                    b.Property<string>("city")
                        .HasColumnType("text");

                    b.Property<DateTime>("dateAdmission")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("dateBirthday")
                        .HasColumnType("datetime");

                    b.Property<string>("email")
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.Property<string>("office")
                        .HasColumnType("text");

                    b.Property<string>("phone")
                        .HasColumnType("text");

                    b.Property<string>("postalCode")
                        .HasColumnType("text");

                    b.Property<double>("salary")
                        .HasColumnType("double");

                    b.Property<string>("state")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
