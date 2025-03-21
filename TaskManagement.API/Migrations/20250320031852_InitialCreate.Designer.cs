﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaskManagement.API.Data;

#nullable disable

namespace TaskManagement.API.Migrations
{
    [DbContext(typeof(TaskManagementDbContext))]
    [Migration("20250320031852_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("TaskManagement.API.Models.TaskItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AssignedTo")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("CompletedAt")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("datetime('now')");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DueDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("LastModifiedAt")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("LastModifiedBy")
                        .HasColumnType("TEXT");

                    b.Property<string>("Priority")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AssignedTo");

                    b.HasIndex("DueDate");

                    b.HasIndex("Status");

                    b.ToTable("Tasks");
                });
#pragma warning restore 612, 618
        }
    }
}
