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
    [Migration("20230607120348_add level")]
    partial class addlevel
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
#pragma warning restore 612, 618
        }
    }
}
