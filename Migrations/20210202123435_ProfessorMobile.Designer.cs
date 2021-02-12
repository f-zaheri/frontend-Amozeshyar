﻿// <auto-generated />
using System;
using Amozeshyar.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Amozeshyar.Migrations
{
    [DbContext(typeof(AmozeshyarDB))]
    [Migration("20210202123435_ProfessorMobile")]
    partial class ProfessorMobile
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Amozeshyar.Database.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("DayAndHoursOfWeeks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("FieldId")
                        .HasColumnType("int");

                    b.Property<int>("ManagerId")
                        .HasColumnType("int");

                    b.Property<double>("Payment")
                        .HasColumnType("float");

                    b.Property<int>("ProfessorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("FieldId");

                    b.HasIndex("ManagerId");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Amozeshyar.Database.Field", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("PracticalHours")
                        .HasColumnType("int");

                    b.Property<int>("TheoryHours")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Fields");
                });

            modelBuilder.Entity("Amozeshyar.Database.FinancialTransaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("About")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<double>("CreditAmount")
                        .HasColumnType("float");

                    b.Property<double>("DebtAmount")
                        .HasColumnType("float");

                    b.Property<int>("InternId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("InternId");

                    b.ToTable("FinancialTransactions");
                });

            modelBuilder.Entity("Amozeshyar.Database.Intern", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Salt")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.HasIndex("Mobile")
                        .IsUnique()
                        .HasFilter("[Mobile] IS NOT NULL");

                    b.ToTable("Interns");
                });

            modelBuilder.Entity("Amozeshyar.Database.Manager", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Salt")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.ToTable("Managers");
                });

            modelBuilder.Entity("Amozeshyar.Database.PreRegisteration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("FieldId")
                        .HasColumnType("int");

                    b.Property<int>("InternId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FieldId");

                    b.HasIndex("InternId");

                    b.ToTable("PreRegisterations");
                });

            modelBuilder.Entity("Amozeshyar.Database.Professor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Field")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Salt")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.HasIndex("Mobile")
                        .IsUnique()
                        .HasFilter("[Mobile] IS NOT NULL");

                    b.ToTable("Professors");
                });

            modelBuilder.Entity("Amozeshyar.Database.Register", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("InternId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("InternId");

                    b.ToTable("Registers");
                });

            modelBuilder.Entity("Amozeshyar.Database.Course", b =>
                {
                    b.HasOne("Amozeshyar.Database.Field", "Field")
                        .WithMany("Courses")
                        .HasForeignKey("FieldId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Amozeshyar.Database.Manager", "Manager")
                        .WithMany("Courses")
                        .HasForeignKey("ManagerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Amozeshyar.Database.Professor", "Professor")
                        .WithMany("Courses")
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Field");

                    b.Navigation("Manager");

                    b.Navigation("Professor");
                });

            modelBuilder.Entity("Amozeshyar.Database.FinancialTransaction", b =>
                {
                    b.HasOne("Amozeshyar.Database.Intern", "Intern")
                        .WithMany("FinancialTransactions")
                        .HasForeignKey("InternId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Intern");
                });

            modelBuilder.Entity("Amozeshyar.Database.PreRegisteration", b =>
                {
                    b.HasOne("Amozeshyar.Database.Field", "Field")
                        .WithMany("PreRegisterations")
                        .HasForeignKey("FieldId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Amozeshyar.Database.Intern", "Intern")
                        .WithMany("PreRegisterations")
                        .HasForeignKey("InternId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Field");

                    b.Navigation("Intern");
                });

            modelBuilder.Entity("Amozeshyar.Database.Register", b =>
                {
                    b.HasOne("Amozeshyar.Database.Course", "Course")
                        .WithMany("Registers")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Amozeshyar.Database.Intern", "Intern")
                        .WithMany("Registers")
                        .HasForeignKey("InternId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Intern");
                });

            modelBuilder.Entity("Amozeshyar.Database.Course", b =>
                {
                    b.Navigation("Registers");
                });

            modelBuilder.Entity("Amozeshyar.Database.Field", b =>
                {
                    b.Navigation("Courses");

                    b.Navigation("PreRegisterations");
                });

            modelBuilder.Entity("Amozeshyar.Database.Intern", b =>
                {
                    b.Navigation("FinancialTransactions");

                    b.Navigation("PreRegisterations");

                    b.Navigation("Registers");
                });

            modelBuilder.Entity("Amozeshyar.Database.Manager", b =>
                {
                    b.Navigation("Courses");
                });

            modelBuilder.Entity("Amozeshyar.Database.Professor", b =>
                {
                    b.Navigation("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}