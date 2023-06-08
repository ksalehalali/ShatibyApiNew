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
    [Migration("20230608121911_add teacher")]
    partial class addteacher
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
                            Id = new Guid("8c94be14-32a3-4c43-8cf3-ac36676762ee"),
                            Name_AR = "الفصل الاول",
                            Name_EN = "First Semester"
                        },
                        new
                        {
                            Id = new Guid("5e3256c1-30f4-46aa-b444-9ace7b766d87"),
                            Name_AR = "الفصل الاول",
                            Name_EN = "Second Semester"
                        },
                        new
                        {
                            Id = new Guid("76d62f62-00d9-4d6b-88fe-9293996f2032"),
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
                            Id = new Guid("37654b1f-3b18-44ac-8232-1fa1361dd119"),
                            Name_AR = "السنة الاولى",
                            Name_EN = "First year",
                            Order_of_theyear = 1
                        },
                        new
                        {
                            Id = new Guid("459937ff-7ebd-4554-9f49-7aaa7f3ace46"),
                            Name_AR = "السنة االثانية",
                            Name_EN = "Second year",
                            Order_of_theyear = 2
                        },
                        new
                        {
                            Id = new Guid("5fe6136d-cbdf-496f-8e7b-9f69e6664200"),
                            Name_AR = "السنة الثالثة",
                            Name_EN = "Third year",
                            Order_of_theyear = 3
                        },
                        new
                        {
                            Id = new Guid("9abd632b-c84f-4492-a09a-76de6c41abe8"),
                            Name_AR = "السنة الرابعة",
                            Name_EN = "Fourth year",
                            Order_of_theyear = 4
                        },
                        new
                        {
                            Id = new Guid("2f15bc36-b67f-4488-a500-23fbffd7c82d"),
                            Name_AR = "السنة الخامسة",
                            Name_EN = "Fifth year",
                            Order_of_theyear = 5
                        },
                        new
                        {
                            Id = new Guid("7ebbef8a-03e1-42d4-917c-1339b1c96e87"),
                            Name_AR = "السنة السادسة",
                            Name_EN = "Sixth year",
                            Order_of_theyear = 6
                        },
                        new
                        {
                            Id = new Guid("d2a25faa-f1a0-4698-97d4-59251a0c457b"),
                            Name_AR = "السنة السابعة",
                            Name_EN = "Seventh year",
                            Order_of_theyear = 7
                        },
                        new
                        {
                            Id = new Guid("e7e0aa66-342d-494a-ac6f-6af85d2678d5"),
                            Name_AR = "السنة الثامنة",
                            Name_EN = "Eighth year",
                            Order_of_theyear = 8
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
