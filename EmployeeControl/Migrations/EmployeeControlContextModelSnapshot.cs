// <auto-generated />
using System;
using EmployeeControl.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmployeeControl.Migrations
{
    [DbContext(typeof(EmployeeControlContext))]
    partial class EmployeeControlContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("EmployeeControl.Models.Appointment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("EmployeesID")
                        .HasColumnType("int");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("hour")
                        .HasColumnType("datetime");

                    b.HasKey("ID");

                    b.HasIndex("EmployeesID");

                    b.ToTable("Appointment");
                });

            modelBuilder.Entity("EmployeeControl.Models.Company", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CNPJ")
                        .HasColumnType("text");

                    b.Property<string>("address")
                        .HasColumnType("text");

                    b.Property<string>("celPhone")
                        .HasColumnType("text");

                    b.Property<string>("city")
                        .HasColumnType("text");

                    b.Property<string>("email")
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.Property<string>("phone")
                        .HasColumnType("text");

                    b.Property<string>("postalCode")
                        .HasColumnType("text");

                    b.Property<string>("state")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("EmployeeControl.Models.Employees", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CPF")
                        .HasColumnType("text");

                    b.Property<int?>("CompanyID")
                        .HasColumnType("int");

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

                    b.HasIndex("CompanyID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("EmployeeControl.Models.Appointment", b =>
                {
                    b.HasOne("EmployeeControl.Models.Employees", "Employees")
                        .WithMany()
                        .HasForeignKey("EmployeesID");
                });

            modelBuilder.Entity("EmployeeControl.Models.Employees", b =>
                {
                    b.HasOne("EmployeeControl.Models.Company", "Company")
                        .WithMany("Employees")
                        .HasForeignKey("CompanyID");
                });
#pragma warning restore 612, 618
        }
    }
}
