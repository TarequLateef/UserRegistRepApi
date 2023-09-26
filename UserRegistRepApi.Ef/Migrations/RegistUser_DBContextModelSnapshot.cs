﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UserRegistRepApi.Ef;

#nullable disable

namespace UserRegistRepApi.Ef.Migrations
{
    [DbContext(typeof(RegistUser_DBContext))]
    partial class RegistUser_DBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("UserRegistRepApi.Core.Models.PosistionsTBL", b =>
                {
                    b.Property<int>("PositionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PositionID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PositionName")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<DateTime>("RegistDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("RegistUserID")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("PositionID");

                    b.ToTable("PositionsTBL", "Users");
                });

            modelBuilder.Entity("UserRegistRepApi.Core.Models.UserPositionTBL", b =>
                {
                    b.Property<int>("UserPositionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserPositionID"));

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PositionID")
                        .HasColumnType("int");

                    b.Property<DateTime>("RegistDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("RegistUserID")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<int>("posistionsPositionID")
                        .HasColumnType("int");

                    b.Property<int>("usersUserID")
                        .HasColumnType("int");

                    b.HasKey("UserPositionID");

                    b.HasIndex("posistionsPositionID");

                    b.HasIndex("usersUserID");

                    b.ToTable("UserPositionTBL", "Users");
                });

            modelBuilder.Entity("UserRegistRepApi.Core.Models.UsersTBL", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MobileNo")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("NationalNo")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.Property<string>("PhoneNo")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<DateTime>("RegistDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("RegistUserID")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("UserPic")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("UserID");

                    b.ToTable("UsersTBL", "Users");
                });

            modelBuilder.Entity("UserRegistRepApi.Core.Models.UserPositionTBL", b =>
                {
                    b.HasOne("UserRegistRepApi.Core.Models.PosistionsTBL", "posistions")
                        .WithMany()
                        .HasForeignKey("posistionsPositionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UserRegistRepApi.Core.Models.UsersTBL", "users")
                        .WithMany()
                        .HasForeignKey("usersUserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("posistions");

                    b.Navigation("users");
                });
#pragma warning restore 612, 618
        }
    }
}