﻿// <auto-generated />
using System;
using AcademicYearCalendar.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AcademicYearCalendar.Migrations.AppDb
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250327080902_update-Resources2")]
    partial class updateResources2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AcademicProgramStudySubject", b =>
                {
                    b.Property<int>("AcademicProgramsId")
                        .HasColumnType("int");

                    b.Property<int>("StudySubjectsId")
                        .HasColumnType("int");

                    b.HasKey("AcademicProgramsId", "StudySubjectsId");

                    b.HasIndex("StudySubjectsId");

                    b.ToTable("AcademicProgramStudySubject");
                });

            modelBuilder.Entity("AcademicYearCalendar.Data.AcademicProgram", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ProgramName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AcademicProgram");
                });

            modelBuilder.Entity("AcademicYearCalendar.Data.Resource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BackgroundCss")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.Property<string>("TextCss")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Resources");
                });

            modelBuilder.Entity("AcademicYearCalendar.Data.ResourceIdSequenceValue", b =>
                {
                    b.Property<long>("Value")
                        .HasColumnType("bigint");

                    b.ToTable((string)null);

                    b.ToView(null, (string)null);
                });

            modelBuilder.Entity("AcademicYearCalendar.Data.Staff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("StaffName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Staff");
                });

            modelBuilder.Entity("AcademicYearCalendar.Data.StudySubject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("SubjectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("StudySubject");
                });

            modelBuilder.Entity("AcademicProgramStudySubject", b =>
                {
                    b.HasOne("AcademicYearCalendar.Data.AcademicProgram", null)
                        .WithMany()
                        .HasForeignKey("AcademicProgramsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AcademicYearCalendar.Data.StudySubject", null)
                        .WithMany()
                        .HasForeignKey("StudySubjectsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AcademicYearCalendar.Data.Resource", b =>
                {
                    b.HasOne("AcademicYearCalendar.Data.Resource", "ParentResource")
                        .WithMany("ChildrenResources")
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("ParentResource");
                });

            modelBuilder.Entity("AcademicYearCalendar.Data.Resource", b =>
                {
                    b.Navigation("ChildrenResources");
                });
#pragma warning restore 612, 618
        }
    }
}
