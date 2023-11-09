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
    [Migration("20231107230414_ColumnEventType")]
    partial class ColumnEventType
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.13");

            modelBuilder.Entity("CourseInstructor", b =>
                {
                    b.Property<int>("CoursesCourseID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("InstructorsID")
                        .HasColumnType("INTEGER");

                    b.HasKey("CoursesCourseID", "InstructorsID");

                    b.HasIndex("InstructorsID");

                    b.ToTable("CourseInstructor");
                });

            modelBuilder.Entity("MUSCAttendance.Models.Attendance", b =>
                {
                    b.Property<int>("AttendanceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CourseID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("EventType")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StudentID")
                        .HasColumnType("INTEGER");

                    b.HasKey("AttendanceID");

                    b.HasIndex("CourseID");

                    b.HasIndex("StudentID");

                    b.ToTable("Attendances");
                });

            modelBuilder.Entity("MUSCAttendance.Models.Course", b =>
                {
                    b.Property<int>("CourseID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Credits")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DepartmentID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("CourseID");

                    b.HasIndex("DepartmentID");

                    b.ToTable("Course", (string)null);
                });

            modelBuilder.Entity("MUSCAttendance.Models.Department", b =>
                {
                    b.Property<int>("DepartmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Budget")
                        .HasColumnType("money");

                    b.Property<Guid>("ConcurrencyToken")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<int?>("InstructorID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.HasKey("DepartmentID");

                    b.HasIndex("InstructorID");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("MUSCAttendance.Models.Instructor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstMidName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT")
                        .HasColumnName("FirstName");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Instructor", (string)null);
                });

            modelBuilder.Entity("MUSCAttendance.Models.OfficeAssignment", b =>
                {
                    b.Property<int>("InstructorID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Location")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("InstructorID");

                    b.ToTable("OfficeAssignments");
                });

            modelBuilder.Entity("MUSCAttendance.Models.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstMidName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT")
                        .HasColumnName("FirstName");

                    b.Property<int>("GraduationYear")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("TotalAttendances")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("Student", (string)null);
                });

            modelBuilder.Entity("CourseInstructor", b =>
                {
                    b.HasOne("MUSCAttendance.Models.Course", null)
                        .WithMany()
                        .HasForeignKey("CoursesCourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MUSCAttendance.Models.Instructor", null)
                        .WithMany()
                        .HasForeignKey("InstructorsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MUSCAttendance.Models.Attendance", b =>
                {
                    b.HasOne("MUSCAttendance.Models.Course", "Course")
                        .WithMany("Attendances")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MUSCAttendance.Models.Student", "Student")
                        .WithMany("Attendances")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("MUSCAttendance.Models.Course", b =>
                {
                    b.HasOne("MUSCAttendance.Models.Department", "Department")
                        .WithMany("Courses")
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("MUSCAttendance.Models.Department", b =>
                {
                    b.HasOne("MUSCAttendance.Models.Instructor", "Administrator")
                        .WithMany()
                        .HasForeignKey("InstructorID");

                    b.Navigation("Administrator");
                });

            modelBuilder.Entity("MUSCAttendance.Models.OfficeAssignment", b =>
                {
                    b.HasOne("MUSCAttendance.Models.Instructor", "Instructor")
                        .WithOne("OfficeAssignment")
                        .HasForeignKey("MUSCAttendance.Models.OfficeAssignment", "InstructorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("MUSCAttendance.Models.Course", b =>
                {
                    b.Navigation("Attendances");
                });

            modelBuilder.Entity("MUSCAttendance.Models.Department", b =>
                {
                    b.Navigation("Courses");
                });

            modelBuilder.Entity("MUSCAttendance.Models.Instructor", b =>
                {
                    b.Navigation("OfficeAssignment");
                });

            modelBuilder.Entity("MUSCAttendance.Models.Student", b =>
                {
                    b.Navigation("Attendances");
                });
#pragma warning restore 612, 618
        }
    }
}
