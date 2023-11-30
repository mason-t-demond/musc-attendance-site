﻿// <auto-generated />
using System;
using MUSCAttendance.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MUSCAttendance.Migrations
{
    [DbContext(typeof(SchoolContext))]
    [Migration("20231129081908_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.13");

            modelBuilder.Entity("MUSCAttendance.Models.Form", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Approved")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("EventDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("HasProgram")
                        .HasColumnType("INTEGER");

                    b.Property<string>("OtherDescription")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Performed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProgramDescription")
                        .HasColumnType("TEXT");

                    b.Property<int?>("StudentID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("StudentID1")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("StudentID");

                    b.HasIndex("StudentID1");

                    b.ToTable("Form", (string)null);
                });

            modelBuilder.Entity("MUSCAttendance.Models.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstMidName")
                        .HasColumnType("TEXT");

                    b.Property<int>("GradYear")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Student", (string)null);
                });

            modelBuilder.Entity("MUSCAttendance.Models.Form", b =>
                {
                    b.HasOne("MUSCAttendance.Models.Student", null)
                        .WithMany("Forms")
                        .HasForeignKey("StudentID");

                    b.HasOne("MUSCAttendance.Models.Student", null)
                        .WithMany("HDXForms")
                        .HasForeignKey("StudentID1");
                });

            modelBuilder.Entity("MUSCAttendance.Models.Student", b =>
                {
                    b.Navigation("Forms");

                    b.Navigation("HDXForms");
                });
#pragma warning restore 612, 618
        }
    }
}