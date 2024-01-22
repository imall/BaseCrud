﻿// <auto-generated />
using BaseCrud.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BaseCrud.Migrations
{
    [DbContext(typeof(CmsContext))]
    [Migration("20240122085117_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BaseCrud.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employee");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Department = "產品部",
                            Email = "imall@gmail.com",
                            Mobile = "0987654321",
                            Name = "imall",
                            Title = "經理"
                        },
                        new
                        {
                            Id = 2,
                            Department = "行銷部",
                            Email = "alice@gmail.com",
                            Mobile = "0987654322",
                            Name = "Alice",
                            Title = "專員"
                        },
                        new
                        {
                            Id = 3,
                            Department = "財務部",
                            Email = "bob@gmail.com",
                            Mobile = "0987654323",
                            Name = "Bob",
                            Title = "經理"
                        },
                        new
                        {
                            Id = 4,
                            Department = "人力資源部",
                            Email = "carol@gmail.com",
                            Mobile = "0987654324",
                            Name = "Carol",
                            Title = "主管"
                        },
                        new
                        {
                            Id = 5,
                            Department = "技術部",
                            Email = "david@gmail.com",
                            Mobile = "0987654325",
                            Name = "David",
                            Title = "工程師"
                        },
                        new
                        {
                            Id = 6,
                            Department = "業務部",
                            Email = "eva@gmail.com",
                            Mobile = "0987654326",
                            Name = "Eva",
                            Title = "業務員"
                        },
                        new
                        {
                            Id = 7,
                            Department = "研發部",
                            Email = "frank@gmail.com",
                            Mobile = "0987654327",
                            Name = "Frank",
                            Title = "研究員"
                        },
                        new
                        {
                            Id = 8,
                            Department = "客服部",
                            Email = "grace@gmail.com",
                            Mobile = "0987654328",
                            Name = "Grace",
                            Title = "客服"
                        },
                        new
                        {
                            Id = 9,
                            Department = "採購部",
                            Email = "henry@gmail.com",
                            Mobile = "0987654329",
                            Name = "Henry",
                            Title = "專員"
                        },
                        new
                        {
                            Id = 10,
                            Department = "行政部",
                            Email = "ivy@gmail.com",
                            Mobile = "0987654330",
                            Name = "Ivy",
                            Title = "行政助理"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}