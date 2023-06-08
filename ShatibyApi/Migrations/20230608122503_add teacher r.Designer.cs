﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShatibyApi.API.Data;

#nullable disable

namespace ShatibyApi.Migrations
{
    [DbContext(typeof(ShatibyDBContext))]
    [Migration("20230608122503_add teacher r")]
    partial class addteacherr
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ShatibyApi.Models.DTO.ImagesUrls", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EventId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("imagesUrls");
                });

            modelBuilder.Entity("ShatibyApi.Models.Domain.Attendance", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("attendances");
                });

            modelBuilder.Entity("ShatibyApi.Models.Domain.Circle", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("LessonsCount")
                        .HasColumnType("int");

                    b.Property<Guid>("LevelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SemesterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("TeacherId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("LevelId");

                    b.HasIndex("SemesterId");

                    b.HasIndex("TeacherId");

                    b.ToTable("circles");
                });

            modelBuilder.Entity("ShatibyApi.Models.Domain.Donation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TheDonor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("TheDonorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("donations");
                });

            modelBuilder.Entity("ShatibyApi.Models.Domain.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<int>("Ege")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("JoinDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name_AR")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name_EN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("employees");
                });

            modelBuilder.Entity("ShatibyApi.Models.Domain.EmployeeSalary", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("employeeSalaries");
                });

            modelBuilder.Entity("ShatibyApi.Models.Domain.Event", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description_AR")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description_EN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name_AR")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name_EN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("events");
                });

            modelBuilder.Entity("ShatibyApi.Models.Domain.Exam", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("exams");
                });

            modelBuilder.Entity("ShatibyApi.Models.Domain.ExamType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Degree")
                        .HasColumnType("float");

                    b.Property<string>("Name_AR")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name_EN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("examTypes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5a700e51-8107-4fb5-98a2-b59508f4ea08"),
                            Degree = 50.0,
                            Name_AR = "الامتحان الشفوي",
                            Name_EN = "Oral examination",
                            UserID = new Guid("cc300768-d7a0-41b4-b784-d9ec669a9b77")
                        },
                        new
                        {
                            Id = new Guid("1b8215e3-89c6-4a18-8735-210df4092ef7"),
                            Degree = 50.0,
                            Name_AR = "الامتحان الكتابي",
                            Name_EN = "Written examination",
                            UserID = new Guid("a11d8662-ae8e-479e-9f72-fa0771ba924f")
                        },
                        new
                        {
                            Id = new Guid("77facf2c-6456-480e-9adc-5229257eec52"),
                            Degree = 50.0,
                            Name_AR = "الامتحان النهائي",
                            Name_EN = "Final exam",
                            UserID = new Guid("272aaf1c-92bd-415f-bf7f-1bd8348a634c")
                        });
                });

            modelBuilder.Entity("ShatibyApi.Models.Domain.Expense", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("expenses");
                });

            modelBuilder.Entity("ShatibyApi.Models.Domain.Grade", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Degree")
                        .HasColumnType("float");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("grades");
                });

            modelBuilder.Entity("ShatibyApi.Models.Domain.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileExtention")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("FileSizeInBytes")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("ShatibyApi.Models.Domain.Lesson", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("lessons");
                });

            modelBuilder.Entity("ShatibyApi.Models.Domain.LessonTime", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Day")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Time")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("lessonTimes");
                });

            modelBuilder.Entity("ShatibyApi.Models.Domain.Level", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description_AR")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description_EN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name_AR")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name_EN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Years")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("levels");

                    b.HasData(
                        new
                        {
                            Id = new Guid("51257a5e-ecdb-4935-a2f7-750b0bafe5a7"),
                            Description_AR = "وصف",
                            Description_EN = "Description",
                            Name_AR = "الفائقون",
                            Name_EN = "Achievers",
                            Years = 2
                        },
                        new
                        {
                            Id = new Guid("9d3e3322-a82a-4c53-be47-70ba4d1f56d5"),
                            Description_AR = "وصف",
                            Description_EN = "Description",
                            Name_AR = "المتميزون",
                            Name_EN = "The Distinguished",
                            Years = 2
                        });
                });

            modelBuilder.Entity("ShatibyApi.Models.Domain.Semester", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name_AR")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name_EN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("semesters");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ba7e2315-4f0e-43d9-bf20-a5064c9fe4d9"),
                            Name_AR = "الفصل الاول",
                            Name_EN = "First Semester"
                        },
                        new
                        {
                            Id = new Guid("05d7e125-cab0-456d-8e3f-b1057f7ca0e9"),
                            Name_AR = "الفصل الاول",
                            Name_EN = "Second Semester"
                        },
                        new
                        {
                            Id = new Guid("8d165cff-d767-4d54-ba77-b4fa3b3a813e"),
                            Name_AR = "الفصل التكميلي",
                            Name_EN = "Supplementary semester"
                        });
                });

            modelBuilder.Entity("ShatibyApi.Models.Domain.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<int>("Ege")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name_AR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name_EN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Rigestered")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("students");
                });

            modelBuilder.Entity("ShatibyApi.Models.Domain.StudentExam", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("studentExams");
                });

            modelBuilder.Entity("ShatibyApi.Models.Domain.Teacher", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<int>("Ege")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("LevelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name_AR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name_EN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PartsSaved")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Rigestered")
                        .HasColumnType("datetime2");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("LevelId");

                    b.ToTable("teachers");
                });

            modelBuilder.Entity("ShatibyApi.Models.Domain.TeacherSalary", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("teacherSalaries");
                });

            modelBuilder.Entity("ShatibyApi.Models.Domain.Year", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name_AR")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name_EN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Order_of_theyear")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("years");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4a08b856-1cca-4c72-bc3c-d0c86162add2"),
                            Name_AR = "السنة الاولى",
                            Name_EN = "First year",
                            Order_of_theyear = 1
                        },
                        new
                        {
                            Id = new Guid("61d22e40-1841-4d5b-9fde-9b5ed74d9bf1"),
                            Name_AR = "السنة االثانية",
                            Name_EN = "Second year",
                            Order_of_theyear = 2
                        },
                        new
                        {
                            Id = new Guid("a71d20c6-1897-426a-80f0-ba174cbcaffc"),
                            Name_AR = "السنة الثالثة",
                            Name_EN = "Third year",
                            Order_of_theyear = 3
                        },
                        new
                        {
                            Id = new Guid("67550298-7d2e-441b-9bda-483f599ee2a8"),
                            Name_AR = "السنة الرابعة",
                            Name_EN = "Fourth year",
                            Order_of_theyear = 4
                        },
                        new
                        {
                            Id = new Guid("d7740361-cfdb-4c4a-b9a0-3cfd6a5aeb9c"),
                            Name_AR = "السنة الخامسة",
                            Name_EN = "Fifth year",
                            Order_of_theyear = 5
                        },
                        new
                        {
                            Id = new Guid("c1a8a03c-c974-4a4e-a824-1c0e9b817daa"),
                            Name_AR = "السنة السادسة",
                            Name_EN = "Sixth year",
                            Order_of_theyear = 6
                        },
                        new
                        {
                            Id = new Guid("1566b38b-e74d-4815-8e05-081e6c81f00e"),
                            Name_AR = "السنة السابعة",
                            Name_EN = "Seventh year",
                            Order_of_theyear = 7
                        },
                        new
                        {
                            Id = new Guid("71d9e5bd-a723-4fdd-a512-38cdafb1d99c"),
                            Name_AR = "السنة الثامنة",
                            Name_EN = "Eighth year",
                            Order_of_theyear = 8
                        });
                });

            modelBuilder.Entity("ShatibyApi.Models.Domain.Circle", b =>
                {
                    b.HasOne("ShatibyApi.Models.Domain.Level", "Level")
                        .WithMany()
                        .HasForeignKey("LevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShatibyApi.Models.Domain.Semester", "Semester")
                        .WithMany()
                        .HasForeignKey("SemesterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShatibyApi.Models.Domain.Teacher", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Level");

                    b.Navigation("Semester");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("ShatibyApi.Models.Domain.Teacher", b =>
                {
                    b.HasOne("ShatibyApi.Models.Domain.Level", "Level")
                        .WithMany()
                        .HasForeignKey("LevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Level");
                });
#pragma warning restore 612, 618
        }
    }
}
